namespace NetDaemonApps.Models;

public record DiscordFooter
{
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; init; }


}
