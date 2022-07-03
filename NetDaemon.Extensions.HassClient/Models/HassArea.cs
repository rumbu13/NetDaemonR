
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassArea
{
    [JsonPropertyName("area_id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("picture")]
    public string? Picture { get; init; }
}
