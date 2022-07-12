namespace NetDaemon.Extensions.HassClient.Models;

public record HassZone
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("latitude")]
    public double? Latitude { get; init; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; init; }

    [JsonPropertyName("radius")]
    public double? Radius { get; init; }

    [JsonPropertyName("passive")]
    public bool? Passive { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}
