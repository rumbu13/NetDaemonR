
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassAnalytics
{
    [JsonPropertyName("preferences")]
    public HassAnalyticsPreferences? Preferences { get; init; }

    [JsonPropertyName("onboarded")]
    public bool? Onboarded { get; init; }
}


public record HassAnalyticsPreferences
{
    [JsonPropertyName("base")]
    public bool? Base { get; init; }

    [JsonPropertyName("diagnostics")]
    public bool? Diagnostics { get; init; }

    [JsonPropertyName("usage")]
    public bool? Usage { get; init; }

    [JsonPropertyName("statistics")]
    public bool? Statistics { get; init; }
}
