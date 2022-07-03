using NetDaemon.Client.HomeAssistant.Model;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassCommand : CommandMessage
{
    public HassCommand(string type)
        => Type = type;
}



