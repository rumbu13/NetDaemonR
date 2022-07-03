
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassResource
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("type")]
    public HassResourceType? Type { get; init; }

    [JsonPropertyName("url")]
    public string? Url { get; init; }

}

public enum HassResourceType
{
    [EnumMember(Value = "js")]
    JavaScript,
    [EnumMember(Value = "css")]
    Css,
    [EnumMember(Value = "module")]
    Module,
    [EnumMember(Value = "html")]
    Html,
}