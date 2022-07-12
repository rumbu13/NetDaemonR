namespace NetDaemon.Extensions.HassClient.Models;

public record HassDeviceIdentifier
{
    public string? Domain { get; init; }

    public string? Identifier { get; init; }

}

