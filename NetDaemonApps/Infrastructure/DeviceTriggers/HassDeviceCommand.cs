using NetDaemon.Client.HomeAssistant.Model;

namespace NetDaemonApps.Infrastructure.DeviceTriggers;

public record HassDeviceCommand : CommandMessage
{
    [JsonPropertyName("device_id")]
    public string DeviceId { get; init; }

    public HassDeviceCommand(string type, string deviceId)
    {
        Type = type;
        DeviceId = deviceId;
    }
}
