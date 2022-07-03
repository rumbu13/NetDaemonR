using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Extensions.HassClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassResourceList : HassCommand
{
    public HassResourceList() : 
        base("lovelace/resources")
    {            
    }
}

internal record HassResourceCreate : HassCommand
{
    public HassResourceCreate(HassResourceType type, string url) : 
        base("lovelace/resources/create")
    {
        this.ResourceType = type;
        this.Url = url;
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("res_type")]
    public HassResourceType ResourceType { get; init; }

    [JsonPropertyName("url")]
    public string Url { get; init; }
}

internal record HassResourceDelete : HassCommand
{
    public HassResourceDelete(string id) : 
        base("lovelace/resources/delete")
    {
        this.ResourceId = id;
    }

    [JsonPropertyName("resource_id")]
    public string ResourceId { get; init; }
}


internal record HassResourceUpdate : HassCommand
{
    public HassResourceUpdate(string id, HassResourceType? type, string? url) :
        base("lovelace/resources/update")
    {
        this.ResourceId = id;
        this.ResourceType = type;
        this.Url = url;
    }

    [JsonPropertyName("resource_id")]
    public string ResourceId { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("res_type")]
    public HassResourceType? ResourceType { get; init; }

    [JsonPropertyName("url")]
    public string? Url { get; init; }
}


