namespace NetDaemonApps.Models;

public record DiscordData
{
    [JsonPropertyName("images")]
    public string[]? Images { get; init; }

    [JsonPropertyName("embed")]
    public DiscordEmbed[]? Embeds { get; init; }

}
