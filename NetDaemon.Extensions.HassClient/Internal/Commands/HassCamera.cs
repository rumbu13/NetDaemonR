using NetDaemon.Extensions.HassClient.Models;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassCameraGetStream : HassCommand
{
    public HassCameraGetStream(string entityId, string? format) : 
        base("camera/stream")
    {
        this.EntityId = entityId;
        this.Format = format;
    }

    [JsonPropertyName("entity_id")]
    public string EntityId { get; init; }

    [JsonPropertyName("format")]
    public string? Format { get; init; }
}

internal record HassCameraGetWebRtc : HassCommand
{
    public HassCameraGetWebRtc(string entityId, string offer) :
        base("camera/web_rtc_offer")
    {
        this.EntityId = entityId;
        this.Offer = offer;
    }

    [JsonPropertyName("entity_id")]
    public string EntityId { get; init; }

    [JsonPropertyName("offer")]
    public string? Offer { get; init; }
}

internal record HassCameraGetPrefs : HassCommand
{
    public HassCameraGetPrefs(string entityId) :
        base("camera/get_prefs")
    {
        this.EntityId = entityId;
    }

    [JsonPropertyName("entity_id")]
    public string EntityId { get; init; }

}

internal record HassCameraUpdatePrefs : HassCommand
{
    public HassCameraUpdatePrefs(string entityId, bool? preloadStream) :
        base("camera/update_prefs")
    {
        this.EntityId = entityId;
        this.Preferences = new HassCameraPreferences() { PreloadStream = preloadStream };
    }

    [JsonPropertyName("entity_id")]
    public string EntityId { get; init; }

    [JsonPropertyName("preferences")]
    public HassCameraPreferences Preferences { get; init; }

}




