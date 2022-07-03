using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassBackupGetInfo : HassCommand
{
    public HassBackupGetInfo() : 
        base("backup/info")
    {            
    }
}

internal record HassBackupCreate : HassCommand
{
    public HassBackupCreate() :
        base("backup/generate")
    {       
    }
}

internal record HassBackupDelete : HassCommand
{
    public HassBackupDelete(string slug) : 
        base("backup/remove")
    {
        this.Slug = slug;
    }

    [JsonPropertyName("slug")]
    public string Slug { get; init; }
}



