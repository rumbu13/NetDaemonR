using NetDaemon.Extensions.HassClient.Internal.Json;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassDevice
{
    [JsonConverter(typeof(JsonAlwaysStringConverter))]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("config_entries")]
    public string[]? ConfigEntries { get; init; }

    [JsonConverter(typeof(JsonDeviceConnectionsConverter))]
    [JsonPropertyName("connections")]
    public IEnumerable<HassDeviceConnection>? Connections { get; init; }

    [JsonConverter(typeof(JsonDeviceIdentifiersConverter))]
    [JsonPropertyName("identifiers")]
    public IEnumerable<HassDeviceIdentifier>? Identifiers { get; init; }

    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; init; }

    [JsonPropertyName("model")]
    public string? Model { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonConverter(typeof(JsonAlwaysStringConverter))]
    [JsonPropertyName("sw_version")]
    public string? SoftwareVersion { get; init; }

    [JsonConverter(typeof(JsonAlwaysStringConverter))]
    [JsonPropertyName("hw_version")]
    public string? HardwareVersion { get; init; }

    [JsonConverter(typeof(JsonAlwaysStringConverter))]
    [JsonPropertyName("via_device_id")]
    public string? ViaDeviceId { get; init; }

    [JsonPropertyName("area_id")]
    public string? AreaId { get; init; }

    [JsonPropertyName("name_by_user")]
    public string? NameByUser { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("entry_type")]
    public HassDeviceType? EntryType { get; init; }

    [JsonPropertyName("disabled_by")]
    public string? DisabledBy { get; init; }

    [JsonPropertyName("configuration_url")]
    public string? ConfigurationUrl { get; init; }

}

