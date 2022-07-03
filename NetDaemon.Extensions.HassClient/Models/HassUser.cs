
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public class HassUser
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("is_owner")]
    public bool? IsOwner { get; init; }

    [JsonPropertyName("is_admin")]
    public bool? IsAdmin { get; init; }

    [JsonPropertyName("credentials")]
    public HassUserCredential?[]? Credentials { get; init; }

    [JsonPropertyName("mfa_modules")]
    public HassUserMfaModule?[]? MfaModules { get; init; }
}

public class HassUserCredential
{
    [JsonPropertyName("auth_provider_type")]
    public string? Id { get; init; }

    [JsonPropertyName("auth_provider_type")]
    public string? Type { get; init; }

}

public class HassUserMfaModule
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }
}