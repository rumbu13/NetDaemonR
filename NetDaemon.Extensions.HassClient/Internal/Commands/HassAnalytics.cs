using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Extensions.HassClient.Models;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;


internal record HassAnalyticsGet : HassCommand
{
    public HassAnalyticsGet() : 
        base("analytics")
    { }

}

internal record HassAnalyticsSet : HassCommand
{
    public HassAnalyticsSet(bool? @base, bool? diagnostics, bool? statistics, bool? usage) : 
        base("analytics/preferences")
    {
        Preferences = new HassAnalyticsPreferences()
        {
            Base = @base,
            Diagnostics = diagnostics,
            Statistics = statistics,
            Usage = usage
        };
    }

    [JsonPropertyName("preferences")]
    public HassAnalyticsPreferences Preferences { get; init; }
}
