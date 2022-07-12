namespace NetDaemon.Extensions.HassClient.Models;

public record HassEntityExtended: HassEntity
{
    [JsonPropertyName("unique_id")]
    public string? UniqueId { get; init; }

    [JsonPropertyName("capabilities")]
    public IDictionary<string, Object>? Capabilities { get; init; }

    [JsonPropertyName("original_name")]
    public string? OriginalName { get; init; }

    [JsonPropertyName("original_icon")]
    public string? OriginalIcon { get; init; }

    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("original_device_class")]
    public string? OriginalDeviceClass { get; init; }
}

