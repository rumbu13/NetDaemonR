namespace NetDaemonApps.Models;

public record DiscordField
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("value")]
    public string? Value { get; init; }

    [JsonPropertyName("inline")]
    public bool? Inline { get; init; }


}
