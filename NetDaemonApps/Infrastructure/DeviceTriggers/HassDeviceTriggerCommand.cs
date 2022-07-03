using NetDaemon.Client.HomeAssistant.Model;

namespace NetDaemonApps.Infrastructure.DeviceTriggers;

public record HassDeviceTriggerCommand : CommandMessage
{
    [JsonPropertyName("trigger")]
    public HassDeviceTrigger Trigger { get; init; }

    public HassDeviceTriggerCommand(HassDeviceTrigger trigger)
    {
        Type = "subscribe_trigger";
        Trigger = trigger;
    }
}
