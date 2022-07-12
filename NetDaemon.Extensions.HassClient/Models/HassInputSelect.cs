namespace NetDaemon.Extensions.HassClient.Models;

public record HassInputSelect
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("options")]
    public string[]? Options { get; init; }

}
