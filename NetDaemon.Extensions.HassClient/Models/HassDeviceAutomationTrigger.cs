namespace NetDaemon.Extensions.HassClient.Models;

public record HassDeviceAutomationTrigger : HassDeviceAutomation
{
    [JsonPropertyName("platform")]
    public string? Platform { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("discovery_id")]
    public string? DiscoveryId { get; init; }

    [JsonPropertyName("variables")]
    public IDictionary<string, object>? Variables { get; init; }

}
