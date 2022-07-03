using NetDaemon.Client.HomeAssistant.Model;

namespace NetDaemonApps.Infrastructure.DeviceTriggers;

public record DeviceTrigger
{
    public string? DeviceId { get; private init; }
    public string? DeviceName { get; private init; }
    public string? ActionType { get; private init; }
    public string? ActionSubtype { get; private init; }

    public DeviceTrigger(DeviceConfig config)
    {
        DeviceId = config.Device?.Identifiers?.First();
        DeviceName = config?.Device?.Name;
        ActionType = config?.Type;
        ActionSubtype = config?.SubType;
    }

    public DeviceTrigger(HassDevice device, HassDeviceTrigger trigger)
    {
        DeviceId = device.Id;
        DeviceName = device.Name;
        ActionType = trigger.Type;
        ActionSubtype = trigger.SubType;
    }
    
}
