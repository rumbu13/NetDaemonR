using Microsoft.Extensions.Logging;
using NetDaemon.Client;
using NetDaemon.Extensions.HassClient;
using System.Reactive.Linq;
using System.Reactive.Subjects;


namespace NetDaemon.Extensions.DeviceTriggers.Internal;

internal class DeviceTriggers : IDeviceTriggers
{
    readonly IHomeAssistantRunner runner;
    readonly ILogger logger;
    readonly Subject<DeviceTrigger> subject = new();
    readonly CancellationTokenSource cancellationTokenSource = new();
    readonly Task initTask;
    readonly Dictionary<int, DeviceTrigger> deviceTriggers = new();

    IDisposable? messageSubscription;

    public DeviceTriggers(IHomeAssistantRunner runner, ILogger<IDeviceTriggers> logger)
    {
        this.runner = runner;
        this.logger = logger;
        this.initTask = InitializeAsync(cancellationTokenSource.Token);
    }

    public async ValueTask DisposeAsync()
    {
        messageSubscription?.Dispose();

        if (!cancellationTokenSource.IsCancellationRequested)
            cancellationTokenSource.Cancel();
        cancellationTokenSource.Dispose();

        foreach (var id in deviceTriggers.Keys)
        {
            try
            {
                await runner!.CurrentConnection!
                    .UnsubscribeDeviceTriggerAsync(id)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                logger.LogWarning(ex, $"Error when unsubscribing from trigger {id}");
            }
        }
    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {              
        var devices = await runner!.CurrentConnection!
            .GetDevicesAsync(cancellationToken)
            .ConfigureAwait(false);

        var areas = await runner!.CurrentConnection!
            .GetAreasAsync(cancellationToken)
            .ConfigureAwait(false);

        if (!(devices?.Any() ?? false))
            return;

        foreach (var device in devices)
        {
            var area = areas?.FirstOrDefault(a => a.Id == device.AreaId);

            var triggers = await runner!.CurrentConnection!
                .GetDeviceTriggersAsync(device.Id!, cancellationToken)
                .ConfigureAwait(false);

            var deviceTriggerList = triggers?.Where(t => t.Platform == "device" && t.Domain == "mqtt");
            if (!(deviceTriggerList?.Any() ?? false))
                continue;

            foreach (var trigger in deviceTriggerList)
            {
                var id = await runner!.CurrentConnection!
                    .SubscribeDeviceTriggerAsync(trigger, cancellationToken)
                    .ConfigureAwait(false);

                deviceTriggers.Add(id, new DeviceTrigger(device, area, trigger));
                cancellationToken.ThrowIfCancellationRequested();
            }
            cancellationToken.ThrowIfCancellationRequested();
        }

        var messages = runner!.CurrentConnection! as IHomeAssistantHassMessages;

        messageSubscription =  messages!.OnHassMessage
            .Where(m => deviceTriggers.ContainsKey(m.Id))
            .Subscribe(m => HandleTrigger(m.Id));
    }

    void HandleTrigger(int id)
    {
        try
        {
            subject.OnNext(deviceTriggers[id]);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error on trigger subscription");
        }
    }

    public IDisposable Subscribe(IObserver<DeviceTrigger> observer)
    {
        return subject.Subscribe(observer);
    }
}
