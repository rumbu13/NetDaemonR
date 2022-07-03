
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassAccessToken
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    [JsonPropertyName("client_name")]
    public string? ClientName { get; init; }

    [JsonPropertyName("client_icon")]
    public string? ClientIcon { get; init; }

    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    [JsonPropertyName("is_current")]
    public bool? IsCurrent { get; init; }

    [JsonPropertyName("last_used_at")]
    public DateTime? LastUsedAt { get; init; }

    [JsonPropertyName("last_used_ip")]
    public string? LastUsedIP { get; init; }

    [JsonPropertyName("auth_provide_type")]
    public string? AuthProviderType { get; init; }

}
