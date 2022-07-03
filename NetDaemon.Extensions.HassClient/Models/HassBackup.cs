
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;


public record HassBackup
{
    [JsonPropertyName("slug")]
    public string? Slug { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("path")]
    public string? Path { get; init; }

    [JsonPropertyName("date")]
    public string? Date { get; init; }

    [JsonPropertyName("size")]
    public double? Size { get; init; }
}
