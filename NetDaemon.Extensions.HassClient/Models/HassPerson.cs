namespace NetDaemon.Extensions.HassClient.Models;

public record HassPerson
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonPropertyName("device_trackers")]
    public string[]? DeviceTrackers { get; init; }

    [JsonPropertyName("picture")]
    public string? Picture { get; init; }
}
