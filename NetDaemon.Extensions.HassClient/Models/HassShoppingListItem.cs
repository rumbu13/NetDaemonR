namespace NetDaemon.Extensions.HassClient.Models;

public record HassShoppingListItem
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("complete")]
    public bool? Complete { get; init; }

}
