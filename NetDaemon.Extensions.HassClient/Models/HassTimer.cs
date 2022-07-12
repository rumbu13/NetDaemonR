using NetDaemon.Extensions.HassClient.Internal.Json;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassTimer
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonConverter(typeof(JsonTimeSpanDurationConverter))]
    [JsonPropertyName("duration")]
    public TimeSpan? Duration { get; init; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; set; }
}
