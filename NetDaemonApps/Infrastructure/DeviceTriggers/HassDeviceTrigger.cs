using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Infrastructure.DeviceTriggers;

public record HassDeviceTrigger
{
    [JsonPropertyName("platform")]
    public string? Platform { get; init; }

    [JsonPropertyName("domain")]
    public string? Domain { get; init; }

    [JsonPropertyName("device_id")]
    public string? DeviceId { get; init; }

    [JsonPropertyName("discovery_id")]
    public string? DiscoveryId { get; init; }

    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("subtype")]
    public string? SubType { get; init; }


}
