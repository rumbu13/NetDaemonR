
using NetDaemon.HassModel;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.CoverApp;

public class CoverHandler
{

    IServices services;
    IScheduler scheduler;

    InputSelectEntity coverState;
    InputNumberEntity coverSlider;
    InputNumberEntity coverPercent;
    InputTextEntity commandUp;
    InputTextEntity commandDown;
    InputNumberEntity secondsToOpen;
    InputNumberEntity secondsToClose;


    int msToOpen;
    int msToClose;
    int msOpenDelay;
    int msCloseDelay;

    public CoverHandler(IServices services, IScheduler scheduler,
        InputButtonEntity openButton,
        InputButtonEntity closeButton,
        InputButtonEntity stopButton,
        InputButtonEntity resetButton,
        InputSelectEntity coverState,
        InputNumberEntity coverSlider,
        InputNumberEntity coverPercent,
        InputNumberEntity secondsToOpen,
        InputNumberEntity secondsToClose,
        InputTextEntity commandUp,
        InputTextEntity commandDown)
    {

        this.services = services;
        this.scheduler = scheduler;

        this.coverState = coverState;
        this.coverSlider = coverSlider;
        this.coverPercent = coverPercent;

        this.secondsToOpen = secondsToOpen;
        this.secondsToClose = secondsToClose;

        UpdateIntervals();

        this.commandUp = commandUp;
        this.commandDown = commandDown;

        secondsToOpen.StateChanges()
            .Subscribe(_ => UpdateIntervals());

        secondsToClose.StateChanges()
            .Subscribe(_ => UpdateIntervals());

        openButton.StateChanges()
            .Subscribe(_ => StartOpenAsync().ContinueWith(_ => { }));

        stopButton.StateChanges()
            .Subscribe(_ => RequestStop());

        closeButton.StateChanges()
            .Subscribe(_ => StartCloseAsync().ContinueWith(_ => { }));

        resetButton.StateChanges()
            .Subscribe(_ => Reset());


        WatchSlider();

    }

    private void UpdateIntervals()
    {
        msToOpen = (int)(secondsToOpen.State ?? 20) * 1000;
        msToClose = (int)(secondsToClose.State ?? 20) * 1000;

        msOpenDelay = msToOpen / 100;
        msCloseDelay = msToClose / 100;
    }

    bool isSwitchUpActive;
    bool isSwitchDownActive;

    IDisposable? sliderWatcher;
    CancellationTokenSource? cts;

    async Task FollowSlider()
    {
        if (coverSlider.State == coverPercent.State)
            return;

        cts?.Cancel();
        cts = new CancellationTokenSource();
        if (coverSlider.State < coverPercent.State)
            await CloseAsync(cts.Token, coverSlider.State ?? 0);
        else
            await OpenAsync(cts.Token, coverSlider.State ?? 100);
        cts?.Dispose();
        cts = null;

    }
    

    async Task StartOpenAsync()
    {
        if (coverPercent.State >= 100)
        {
            coverState.SelectOption("open");
            return;
        }

        cts?.Cancel();
        cts = new CancellationTokenSource();
        await OpenAsync(cts.Token);
        cts?.Dispose();
        cts = null;
    }

    async Task StartCloseAsync()
    {
        if (coverPercent.State <= 0)
        {
            coverState.SelectOption("closed");
            return;
        }

        cts?.Cancel();
        cts = new CancellationTokenSource();
        await CloseAsync(cts.Token);
        cts?.Dispose();
        cts = null;
    }

    async Task OpenAsync(CancellationToken ct, double target = 100)
    {
        coverState.SelectOption("opening");

        await SendRemoteUpAsync();


        double msTarget = Math.Min(target, 100) * msToOpen / 100;

        var msPassed = (coverPercent.State ?? 100) * msToOpen / 100;
        try
        {
            DateTime start = DateTime.Now;
            var elapsed = (DateTime.Now - start).TotalMilliseconds + msPassed;
            do
            {
                coverPercent.SetValue(Math.Ceiling(elapsed / msToOpen * 100));
                await Task.Delay(msOpenDelay, ct);
                elapsed = (DateTime.Now - start).TotalMilliseconds + msPassed;
                ct.ThrowIfCancellationRequested();
            } while (elapsed < msTarget);

            if (target > 99)
                coverPercent.SetValue(100);
        }
        catch (OperationCanceledException)
        { }


        await HandleSwitchAsync();

        if (coverPercent.State <= 0)
            coverState.SelectOption("closed");
        else
            coverState.SelectOption("open");

    }

    async Task CloseAsync(CancellationToken ct, double target = 0)
    {
        coverState.SelectOption("closing");

        await SendRemoteDownAsync();

        var msPassed = (100 - (coverPercent.State ?? 100)) * msToClose / 100;

        double msTarget = (100 - Math.Min(target, 100)) * msToClose / 100;

        bool complete = false;
        try
        {
            DateTime start = DateTime.Now;
            var elapsed = (DateTime.Now - start).TotalMilliseconds + msPassed;
            do
            {
                coverPercent.SetValue(100 - Math.Ceiling(elapsed / msToClose * 100));
                await Task.Delay(msCloseDelay, ct);
                elapsed = (DateTime.Now - start).TotalMilliseconds + msPassed;
                ct.ThrowIfCancellationRequested();
            } while (elapsed < msTarget);

            if (target < 1)
            {
                coverPercent.SetValue(0);
                complete = true;
            }
        }
        catch (OperationCanceledException)
        { }

        await HandleSwitchAsync();

        if (complete)
            coverState.SelectOption("closed");
        else
            coverState.SelectOption("open");
    }

    void RequestStop()
    {
        cts?.Cancel();
        cts?.Dispose();
        cts = null;
    }

    IDisposable? switchUpSchedule;
    IDisposable? switchDownSchedule;

    async Task HandleSwitchAsync()
    {
        if (isSwitchUpActive)
        {

            switchUpSchedule?.Dispose();
            switchUpSchedule = null;
            services.Remote.SendCommand(ServiceTarget.FromEntity("remote.office_remote"), commandUp.State!, device: "livolo_remote");
            isSwitchUpActive = false;
            await Task.Delay(250);
        }
        else if (isSwitchDownActive)
        {
            switchDownSchedule?.Dispose();
            switchDownSchedule = null;
            isSwitchDownActive = false;
            services.Remote.SendCommand(ServiceTarget.FromEntity("remote.office_remote"), commandDown.State!, device: "livolo_remote");
            await Task.Delay(250);
        }
    }

    async Task SendRemoteUpAsync()
    {
        await HandleSwitchAsync();
        services.Remote.SendCommand(ServiceTarget.FromEntity("remote.office_remote"), commandUp.State!, device: "livolo_remote");
        isSwitchUpActive = true;
        switchUpSchedule = scheduler.Schedule(TimeSpan.FromSeconds(50), () => isSwitchUpActive = false);

    }

    async Task SendRemoteDownAsync()
    {
        await HandleSwitchAsync();
        services.Remote.SendCommand(ServiceTarget.FromEntity("remote.office_remote"), commandDown.State!, device: "livolo_remote");
        isSwitchDownActive = true;
        switchDownSchedule = scheduler.Schedule(TimeSpan.FromSeconds(50), () => isSwitchDownActive = false);

    }

    void WatchSlider()
    {
        sliderWatcher = coverSlider.StateChanges()
            .Subscribe(_ => FollowSlider().ContinueWith(_ => { }));
    }

    void Reset()
    {
        sliderWatcher?.Dispose();
        coverPercent.SetValue(coverSlider.State ?? 100);
        if (coverSlider.State == 0)
            coverState.SelectOption("closed");
        else
            coverState.SelectOption("open");

        WatchSlider();
    }

}
