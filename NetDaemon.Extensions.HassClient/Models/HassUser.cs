namespace NetDaemon.Extensions.HassClient.Models;

public class HassUser
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("username")]
    public string? Username { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("is_owner")]
    public bool? IsOwner { get; init; }

    [JsonPropertyName("is_active")]
    public bool? IsActive { get; init; }

    [JsonPropertyName("local_only")]
    public bool? LocalOnly { get; init; }

    [JsonPropertyName("system_generated")]
    public bool? SystemGenerated { get; init; }

    [JsonPropertyName("group_ids")]
    public string[]? Groups { get; init; }

    [JsonPropertyName("credentials")]
    public HassUserCredential?[]? Credentials { get; init; }


}


