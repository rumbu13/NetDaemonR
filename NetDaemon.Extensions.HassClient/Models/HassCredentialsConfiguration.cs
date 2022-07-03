
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassCredentialsConfiguration
{
    [JsonPropertyName("domains")]
    public string[]? Domains { get; init; }

    [JsonPropertyName("integrations")]
    public IDictionary<string, HassCredentialsConfigurationPlaceholder>? Integrations { get; init; }
}

public record HassCredentialsConfigurationPlaceholder
{
    [JsonPropertyName("description_placeholders")]
    public IDictionary<string, string>? Placeholders { get; init; }
}