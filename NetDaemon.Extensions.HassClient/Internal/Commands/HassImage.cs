using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassImageList : HassCommand
{
    public HassImageList() : 
        base("image/list")
    {            
    }
}

internal record HassImageCreate : HassCommand
{
    public HassImageCreate(string file) : 
        base("image/create")
    {
        this.File = file;
    }

    [JsonPropertyName("file")]
    public string File { get; init; }
}

internal record HassImageDelete : HassCommand
{
    public HassImageDelete(string id) : 
        base("image/delete")
    {
        this.ImageId = id;
    }

    [JsonPropertyName("image_id")]
    public string ImageId { get; init; }
}


internal record HassImageUpdate : HassCommand
{
    public HassImageUpdate(string id, string? name) :
        base("image/update")
    {
        this.ImageId = id;
        this.Name = name;
    }

    [JsonPropertyName("image_id")]
    public string ImageId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }
}


