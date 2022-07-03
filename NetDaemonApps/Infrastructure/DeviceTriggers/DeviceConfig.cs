using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Infrastructure.DeviceTriggers;

public record DeviceConfig
{
    [JsonPropertyName("automation_type")]
    public string? AutomationType { get; init; }

    [JsonPropertyName("payload")]
    public string? Payload { get; init; }

    [JsonPropertyName("qos")]
    public int? QualityOfService { get; init; }

    [JsonPropertyName("topic")]
    public string? Topic { get; init; }

    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("subtype")]
    public string? SubType { get; init; }

    [JsonPropertyName("device")]
    public MqttDeviceAttributes? Device { get; init; }


}
