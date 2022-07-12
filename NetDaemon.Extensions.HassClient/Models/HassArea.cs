namespace NetDaemon.Extensions.HassClient.Models;

public record HassArea
{
    [JsonPropertyName("area_id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("picture")]
    public string? Picture { get; set; }
}
