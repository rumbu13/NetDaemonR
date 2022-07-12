namespace NetDaemon.Extensions.HassClient.Models;

public record HassCounter
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("initial")]
    public int? InitialValue { get; init; }

    [JsonPropertyName("step")]
    public int? Step { get; init; }

    [JsonPropertyName("minimum")]
    public int? Minimum { get; init; }

    [JsonPropertyName("maximum")]
    public int? Maximum { get; init; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; init; }

}
