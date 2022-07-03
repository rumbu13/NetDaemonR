using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassInputButtonList : HassCommand
{
    public HassInputButtonList() : 
        base("input_button/list")
    {            
    }
}

internal record HassInputButtonCreate : HassCommand
{
    public HassInputButtonCreate(string name, string? icon) : 
        base("input_button/create")
    {
        this.Name = name;
        this.Icon = icon;
    }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}

internal record HassInputButtonDelete : HassCommand
{
    public HassInputButtonDelete(string id) : 
        base("input_button/delete")
    {
        this.InputButtonId = id;
    }

    [JsonPropertyName("input_button_id")]
    public string InputButtonId { get; init; }
}


internal record HassInputButtonUpdate : HassCommand
{
    public HassInputButtonUpdate(string id, string? name, string? icon) :
        base("input_button/update")
    {
        this.InputButtonId = id;
        this.Name = name;
        this.Icon = icon;
    }

    [JsonPropertyName("input_button_id")]
    public string InputButtonId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}


