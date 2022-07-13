using Microsoft.Extensions.Logging;
using NetDaemon.AppModel;
using NetDaemon.Client;
using NetDaemon.Extensions.HassClient;
using NetDaemon.HassModel;
using System.Reactive.Linq;
using System.Reactive.Subjects;


namespace NetDaemon.Extensions.DeviceTriggers.Internal;

internal class DeviceTriggers : IDeviceTriggers
{
    readonly IHomeAssistantRunner runner;
    readonly ILogger logger;
    readonly Subject<DeviceTrigger> subject = new();
    readonly CancellationTokenSource cancellationTokenSource = new();    
    readonly Dictionary<int, DeviceTrigger> deviceTriggers = new();

    IDisposable connectSubscription;
    IDisposable disconnectSubscription;
    IDisposable? changeSubscription;
    IDisposable? messageSubscription;

    public DeviceTriggers(IHomeAssistantRunner runner, ILogger<IDeviceTriggers> logger)
    {
        this.runner = runner;
        this.logger = logger;

        disconnectSubscription = runner.OnDisconnect
            .Subscribe(_ => Disconnected());
        connectSubscription = runner.OnConnect
            .SubscribeAsync(async _ => await ConnectedAsync(cancellationTokenSource.Token).ConfigureAwait(false));

        InitializeAsync(cancellationTokenSource.Token)
            .ContinueWith(t =>
                logger.LogError(t.Exception, "Error initializing device triggers"),
                TaskContinuationOptions.OnlyOnFaulted);
    }

    public async ValueTask DisposeAsync()
    {
        if (!cancellationTokenSource.IsCancellationRequested)
            cancellationTokenSource.Cancel();

        disconnectSubscription?.Dispose();
        connectSubscription?.Dispose();
        messageSubscription?.Dispose();
        changeSubscription?.Dispose();

        if (runner.CurrentConnection != null)
        {
            foreach (var id in deviceTriggers.Keys)
            {
                try
                {
                    await runner.CurrentConnection!
                        .UnsubscribeDeviceTriggerAsync(id)
                        .ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    logger.LogWarning(ex, $"Error when unsubscribing from trigger {id}");
                }
            }
        }
    }
    
    async Task LoadTriggersAsync(CancellationToken cancellationToken)
    {
        var devices = await runner.CurrentConnection!
            .GetDevicesAsync(cancellationToken).ConfigureAwait(false);

        var areas = await runner.CurrentConnection!
            .GetAreasAsync(cancellationToken).ConfigureAwait(false);

        if (!(devices?.Any() ?? false))
            return;

        foreach (var device in devices)
        {
            var area = areas?.FirstOrDefault(a => a.Id == device.AreaId);

            var triggers = await runner.CurrentConnection!
                .GetDeviceTriggersAsync(device.Id!, cancellationToken)
                .ConfigureAwait(false);

            var deviceTriggerList = triggers?.Where(t => t.Platform == "device" && t.Domain == "mqtt");
            if (!(deviceTriggerList?.Any() ?? false))
                continue;

            foreach (var trigger in deviceTriggerList)
            {
                var id = await runner.CurrentConnection!
                    .SubscribeDeviceTriggerAsync(trigger, cancellationToken)
                    .ConfigureAwait(false);

                deviceTriggers.Add(id, new DeviceTrigger(device, area, trigger));
                if (cancellationToken.IsCancellationRequested)
                    break;
            }
            if (cancellationToken.IsCancellationRequested)
                break;
        }

        var messages = runner.CurrentConnection! as IHomeAssistantHassMessages;
        messageSubscription = messages!.OnHassMessage
            .Where(m => deviceTriggers.ContainsKey(m.Id))
            .Subscribe(m => HandleTrigger(m.Id));
    }

    Task ConnectedAsync(CancellationToken cancellationToken)
    {        
        changeSubscription = runner.CurrentConnection!.OnHomeAssistantEvent
            .Where(e => e.EventType is "device_registry_updated" or "area_registry_updated")
            .SubscribeAsync(async _ => await UpdatedAsync(cancellationToken).ConfigureAwait(false));
        return LoadTriggersAsync(cancellationToken);
    }

    void Disconnected()
    {
        deviceTriggers.Clear();
        changeSubscription?.Dispose();
        messageSubscription?.Dispose();
    }

    Task UpdatedAsync(CancellationToken cancellationToken)
    {
        deviceTriggers.Clear();
        messageSubscription?.Dispose();
        return LoadTriggersAsync(cancellationToken);
    }


    void HandleTrigger(int id)
    {
        try
        {
            subject.OnNext(deviceTriggers[id]);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"Error on trigger subscription {id}");
        }
    }

    public IDisposable Subscribe(IObserver<DeviceTrigger> observer)
    {
        return subject.Subscribe(observer);
    }

    public Task InitializeAsync(CancellationToken cancellationToken)
    {
        if (runner.CurrentConnection != null)
            return ConnectedAsync(cancellationToken);
        return Task.CompletedTask;
    }


}
