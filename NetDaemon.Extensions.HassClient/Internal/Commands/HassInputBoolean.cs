using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassInputBooleanList : HassCommand
{
    public HassInputBooleanList() : 
        base("input_boolean/list")
    {            
    }
}

internal record HassInputBooleanCreate : HassCommand
{
    public HassInputBooleanCreate(string name, bool? initialValue, string? icon) : 
        base("input_boolean/create")
    {
        this.Name = name;
        this.InitialValue = initialValue;
        this.Icon = icon;
    }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("initial")]
    public bool? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}

internal record HassInputBooleanDelete : HassCommand
{
    public HassInputBooleanDelete(string id) : 
        base("input_boolean/delete")
    {
        this.InputBooleanId = id;
    }

    [JsonPropertyName("input_boolean_id")]
    public string InputBooleanId { get; init; }
}


internal record HassInputBooleanUpdate : HassCommand
{
    public HassInputBooleanUpdate(string id, string? name, bool? initialValue, string? icon) :
        base("input_boolean/update")
    {
        this.InputBooleanId = id;
        this.Name = name;
        this.InitialValue = initialValue;
        this.Icon = icon;
    }

    [JsonPropertyName("input_boolean_id")]
    public string InputBooleanId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("initial")]
    public bool? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}


