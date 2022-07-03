
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassPath
{
    [JsonPropertyName("path")]
    public string? Path { get; init; }
}
