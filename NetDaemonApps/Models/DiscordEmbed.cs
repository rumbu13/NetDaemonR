namespace NetDaemonApps.Models;

public record DiscordEmbed
{
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("color")]
    public int? Color { get; init; }

    [JsonPropertyName("url")]
    public string? Url { get; init; }

    [JsonPropertyName("author")]
    public DiscordAuthor? Author { get; init; }

    [JsonPropertyName("fields")]
    public DiscordField[]? Fields { get; init; }

    [JsonPropertyName("thumbnail")]
    public DiscordThumbnail? Thumbnail { get; init; }

    [JsonPropertyName("footer")]
    public DiscordFooter? Footer { get; init; }

    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; init; }
}
