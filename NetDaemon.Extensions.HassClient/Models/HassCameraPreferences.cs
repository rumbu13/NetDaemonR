
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassCameraPreferences
{
    [JsonPropertyName("preload_stream")]
    public bool? PreloadStream { get; init; }

}
