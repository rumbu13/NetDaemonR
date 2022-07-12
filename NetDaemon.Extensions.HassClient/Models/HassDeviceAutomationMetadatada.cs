namespace NetDaemon.Extensions.HassClient.Models;

public record HassDeviceAutomationMetadatada
{
    [JsonPropertyName("secondary")]
    public bool? Secondary { get; init; }
}



