namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassAlexaList : HassCommand
{
    public HassAlexaList() : 
        base("cloud/alexa/entities")
    {            
    }
}

internal record HassAlexaSync : HassCommand
{
    public HassAlexaSync() :
        base("cloud/alexa/sync")
    {
    }
}


