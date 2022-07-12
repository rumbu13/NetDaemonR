namespace NetDaemon.Extensions.HassClient.Models;

public record HassInputDateTime
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("has_date")]
    public bool? HasDate { get; init; }

    [JsonPropertyName("has_time")]
    public bool? HasTime { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

}
