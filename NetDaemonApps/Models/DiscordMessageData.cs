namespace NetDaemonApps.Models;

public record DiscordMessageData
{
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonPropertyName("target")]
    public string[]? Targets { get; init; }

    [JsonPropertyName("data")]
    public DiscordData? Data { get; init; }
}
