namespace NetDaemon.Extensions.HassClient.Models;

public record HassDeviceAutomationCondition : HassDeviceAutomation
{
    [JsonPropertyName("condition")]
    public string? Condition { get; init; }
}

