
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassDeviceAutomation
{
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    [JsonPropertyName("device_id")]
    public string? DeviceId { get; init; }

    [JsonPropertyName("domain")]
    public string? Domain { get; init; }

    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }

    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("subtype")]
    public string? Subtype { get; init; }

    [JsonPropertyName("event")]
    public string? Event { get; init; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    [JsonPropertyName("metadata")]
    public HassDeviceAutomationMetadatada? Metadata { get; init; }
}

public record HassDeviceAction: HassDeviceAutomation
{

}

public record HassDeviceCondition : HassDeviceAutomation
{
    [JsonPropertyName("condition")]
    public string? Condition { get; init; }
}

public record HassDeviceTrigger : HassDeviceAutomation
{
    [JsonPropertyName("platform")]
    public string? Platform { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("variables")]
    public IDictionary<string, Object>? Variables { get; init; }

}

public record HassDeviceAutomationMetadatada
{
    [JsonPropertyName("secondary")]
    public bool? Secondary { get; init; }
}



