
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassDashboard
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("require_admin")]
    public bool? RequiresAdmin { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonPropertyName("show_in_sidebar")]
    public bool? ShowInSidebar { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("mode")]
    public HassDashboardMode? Type { get; init; }

    [JsonPropertyName("url_path")]
    public string? Url { get; init; }

}

public enum HassDashboardMode
{
    [EnumMember(Value = "storage")]
    Storage
}