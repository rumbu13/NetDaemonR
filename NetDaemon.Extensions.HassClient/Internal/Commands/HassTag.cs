using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassTagList : HassCommand
{
    public HassTagList() : 
        base("tag/list")
    {            
    }
}

internal record HassTagCreate : HassCommand
{
    public HassTagCreate(string? id, string? name, string? description, DateTime? lastScanned) : 
        base("tag/create")
    {
        this.TagId = id;
        this.Name = name;
        this.Description = description;
        this.LastScanned = lastScanned;

    }

    [JsonPropertyName("tag_id")]
    public string? TagId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("last_scanned")]
    public DateTime? LastScanned { get; init; }

}

internal record HassTagDelete : HassCommand
{
    public HassTagDelete(string id) : 
        base("tag/delete")
    {
        this.TagId = id;
    }

    [JsonPropertyName("tag_id")]
    public string TagId { get; init; }
}


internal record HassTagUpdate : HassCommand
{
    public HassTagUpdate(string id, string? name, string? description, DateTime? lastScanned) :
        base("tag/update")
    {
        this.TagId = id;
        this.Name = name;
        this.Description = description;
        this.LastScanned = lastScanned;
    }

    [JsonPropertyName("tag_id")]
    public string TagId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("last_scanned")]
    public DateTime? LastScanned { get; init; }
}


