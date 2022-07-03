using NetDaemonApps.Infrastructure.DeviceTriggers;

namespace NetDaemonApps.Automations.DeviceTriggersApp;

[Focus]
[NetDaemonApp]
internal class DeviceTriggersApp
{
    

    public DeviceTriggersApp(IHassDeviceTriggers deviceTriggers, ILogger<DeviceTriggersApp> logger)
    {
        deviceTriggers
            .Subscribe(d => logger.LogDebug($"{d.DeviceId}, {d.DeviceName}, {d.ActionType}, {d.ActionSubtype}"));

        deviceTriggers.Where(d => d.DeviceName == "Office Chair Vibration Sensor")
            .Subscribe(d => logger.LogDebug($"Stay still, I sense some {d.ActionSubtype} on the chair"));


    }

   


    

}
