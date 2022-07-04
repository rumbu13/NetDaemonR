
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassDeviceCapabilities
{
    [JsonPropertyName("extra_fields")]
    public HassSchema[]? ExtraFields { get; init; }
      
}
