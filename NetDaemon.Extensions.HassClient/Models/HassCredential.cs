
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassCredential
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("domain")]
    public string? Domain { get; init; }

    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; init; }

    [JsonPropertyName("auth_domain")]
    public string? AuthDomain { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

}
