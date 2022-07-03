
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassCameraAnswer
{
    [JsonPropertyName("answer")]
    public string? Answer { get; init; }

}
