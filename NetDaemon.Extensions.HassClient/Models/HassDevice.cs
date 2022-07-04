
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassDevice
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("config_entries")]
    public string[]? ConfigEntries { get; init; }

    [JsonPropertyName("connections")]
    public string [][]? Connections { get; init; }

    [JsonPropertyName("identifiers")]
    public string[][]? Identifiers { get; init; }

    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; init; }

    [JsonPropertyName("model")]
    public string? Model { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("sw_version")]
    public string? SoftwareVersion { get; init; }

    [JsonPropertyName("hw_version")]
    public string? HardwareVersion { get; init; }

    [JsonPropertyName("via_device_id")]
    public string? ViaDeviceId { get; init; }

    [JsonPropertyName("area_id")]
    public string? AreaId { get; init; }

    [JsonPropertyName("name_by_user")]
    public string? NameByUser { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("entry_type")]
    public HassDeviceEntryType? EntryType { get; init; }

    [JsonPropertyName("disabled_by")]
    public string? DisabledBy { get; init; }

    [JsonPropertyName("configuration_url")]
    public string? ConfigurationUrl { get; init; }

}

public enum HassDeviceEntryType
{
    [EnumMember(Value="service")]
    Service
}