namespace NetDaemon.Extensions.HassClient.Models;

public record HassInputButton
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

   

}
