namespace NetDaemonApps.Models;

public record DiscordThumbnail
{
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
