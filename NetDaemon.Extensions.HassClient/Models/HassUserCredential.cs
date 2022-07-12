namespace NetDaemon.Extensions.HassClient.Models;

public class HassUserCredential
{
    [JsonPropertyName("type")]
    public string? Type { get; init; }

}