
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassCameraStream
{
    [JsonPropertyName("url")]
    public string? Url { get; init; }

}
