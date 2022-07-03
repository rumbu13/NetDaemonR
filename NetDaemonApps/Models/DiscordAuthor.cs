namespace NetDaemonApps.Models;

public record DiscordAuthor
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("url")]
    public DiscordEmbed? Url { get; init; }

    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; init; }

}
