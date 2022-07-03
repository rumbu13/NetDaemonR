using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassZoneList : HassCommand
{
    public HassZoneList() : 
        base("zone/list")
    {            
    }
}

internal record HassZoneCreate : HassCommand
{
    public HassZoneCreate(string name, double latitude, double longitude, double? radius, bool? passive, string? icon) :
        base("zone/create")
    {
        this.Name = name;
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Radius = radius;
        this.Passive = passive;
        this.Icon = icon;
    }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; init; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; init; }

    [JsonPropertyName("radius")]
    public double? Radius { get; init; }

    [JsonPropertyName("passive")]
    public bool? Passive { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

}

internal record HassZoneDelete : HassCommand
{
    public HassZoneDelete(string id) : 
        base("zone/delete")
    {
        this.ZoneId = id;
    }

    [JsonPropertyName("zone_id")]
    public string ZoneId { get; init; }
}


internal record HassZoneUpdate : HassCommand
{
    public HassZoneUpdate(string id, string? name, double? latitude, double? longitude, double? radius, bool? passive, 
        string? icon) :
        base("zone/update")
    {
        this.ZoneId = id;
        this.Name = name;
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Radius = radius;
        this.Passive = passive;
        this.Icon = icon;
    }

    [JsonPropertyName("zone_id")]
    public string ZoneId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("latitude")]
    public double? Latitude { get; init; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; init; }

    [JsonPropertyName("radius")]
    public double? Radius { get; init; }

    [JsonPropertyName("passive")]
    public bool? Passive { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}


