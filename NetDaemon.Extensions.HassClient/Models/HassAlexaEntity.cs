
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassAlexaEntity
{
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }

    [JsonPropertyName("display_categories")]
    public string?[]? DisplayCategories { get; init; }

    [JsonPropertyName("interfaces")]
    public string?[]? Interfaces { get; init; }

}
