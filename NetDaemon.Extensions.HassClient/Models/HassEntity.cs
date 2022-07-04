
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassEntity
{
    [JsonPropertyName("entity_id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("platform")]
    public string? Platform { get; init; }

    [JsonPropertyName("config_entry_id")]
    public string? ConfigEntryId { get; init; }

    [JsonPropertyName("device_id")]
    public string? DeviceId { get; init; }

    [JsonPropertyName("area_id")]
    public string? AreaId { get; init; }

    [JsonPropertyName("disabled_by")]
    public string? DisabledBy { get; init; }

    [JsonPropertyName("hidden_by")]
    public string? HiddenBy { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("entity_category")]
    public HassEntityCategory? Category { get; init; }

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

public enum HassEntityCategory
{
    [EnumMember(Value="config")]
    Configuration,
    [EnumMember(Value = "diagnostic")]
    Diagnostic
}