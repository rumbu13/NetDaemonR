using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassAreaList : HassCommand
{
    public HassAreaList() : 
        base("config/area_registry/list")
    {            
    }
}

internal record HassAreaCreate : HassCommand
{
    public HassAreaCreate(string name, string? picture) : 
        base("config/area_registry/create")
    {
        this.Name = name;
        this.Picture = picture;
    }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("picture")]
    public string? Picture { get; init; }
}

internal record HassAreaDelete : HassCommand
{
    public HassAreaDelete(string id) : 
        base("config/area_registry/delete")
    {
        this.AreaId = id;
    }

    [JsonPropertyName("area_id")]
    public string AreaId { get; init; }
}


internal record HassAreaUpdate : HassCommand
{
    public HassAreaUpdate(string id, string? name, string? picture) : 
        base("config/area_registry/update")
    {
        this.AreaId = id;
        this.Name = name;
        this.Picture = picture;
    }

    [JsonPropertyName("area_id")]
    public string AreaId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("picture")]
    public string? Picture { get; init; }
}


