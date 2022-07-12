namespace NetDaemon.Extensions.HassClient.Models;

public record HassTag
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("tag_id")]
    public string? TagId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("last_scanned")]
    public DateTime? LastScanned { get; init; }
}
