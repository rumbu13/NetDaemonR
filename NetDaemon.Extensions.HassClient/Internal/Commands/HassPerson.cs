using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassPersonList : HassCommand
{
    public HassPersonList() : 
        base("person/list")
    {            
    }
}

internal record HassPersonCreate : HassCommand
{
    public HassPersonCreate(string name, string? userId, IEnumerable<string>? deviceTrackers, string? picture) : 
        base("person/create")
    {
        this.Name = name;
        this.UserId = userId;
        this.DeviceTrackers = deviceTrackers?.ToArray();
        this.Picture = picture;
    }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonPropertyName("device_trackers")]
    public string[]? DeviceTrackers { get; init; }

    [JsonPropertyName("picture")]
    public string? Picture { get; init; }

}

internal record HassPersonDelete : HassCommand
{
    public HassPersonDelete(string id) : 
        base("person/delete")
    {
        this.PersonId = id;
    }

    [JsonPropertyName("person_id")]
    public string PersonId { get; init; }
}


internal record HassPersonUpdate : HassCommand
{
    public HassPersonUpdate(string id, string? name, string? userId, IEnumerable<string>? deviceTrackers, 
        string? picture) :
        base("person/update")
    {
        this.PersonId = id;
        this.Name = name;
        this.UserId = userId;
        this.DeviceTrackers = deviceTrackers?.ToArray();
        this.Picture = picture;
    }

    [JsonPropertyName("person_id")]
    public string PersonId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonPropertyName("device_trackers")]
    public string[]? DeviceTrackers { get; init; }

    [JsonPropertyName("picture")]
    public string? Picture { get; init; }
}


