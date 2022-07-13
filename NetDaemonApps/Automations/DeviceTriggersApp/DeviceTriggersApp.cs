using NetDaemon.Extensions.DeviceTriggers;

namespace NetDaemonApps.Automations.DeviceTriggersApp;

[Focus]
[NetDaemonApp]
internal class DeviceTriggersApp
{
    

    public DeviceTriggersApp(IDeviceTriggers deviceTriggers, ILogger<DeviceTriggersApp> logger)
    {
        deviceTriggers
            .Subscribe(d => logger.LogDebug($"{d.DeviceId}, {d.DeviceName}, {d.Type}, {d.Subtype}"));

        deviceTriggers.Where(d => d.DeviceName == "Office Chair Vibration Sensor")
            .Subscribe(d => logger.LogDebug($"Stay still, I sense some {d.Subtype} on the chair"));


    }

   


    

}
