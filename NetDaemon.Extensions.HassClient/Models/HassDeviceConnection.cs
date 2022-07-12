namespace NetDaemon.Extensions.HassClient.Models;

public record HassDeviceConnection
{
    public string? ConnectionType { get; init; }

    public string? Identifier { get; init; }

}

