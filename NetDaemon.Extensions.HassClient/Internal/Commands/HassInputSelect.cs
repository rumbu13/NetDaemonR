using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassInputSelectList : HassCommand
{
    public HassInputSelectList() : 
        base("input_select/list")
    {            
    }
}

internal record HassInputSelectCreate : HassCommand
{
    public HassInputSelectCreate(string name, IEnumerable<string> options, string? initialValue, string? icon) : 
        base("input_select/create")
    {
        this.Name = name;
        this.Options = options.ToArray();
        this.InitialValue = initialValue;
        this.Icon = icon;
    }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("options")]
    public string[] Options { get; init; }

    [JsonPropertyName("initial")]
    public string? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

}

internal record HassInputSelectDelete : HassCommand
{
    public HassInputSelectDelete(string id) : 
        base("input_select/delete")
    {
        this.InputSelectId = id;
    }

    [JsonPropertyName("input_select_id")]
    public string InputSelectId { get; init; }
}


internal record HassInputSelectUpdate : HassCommand
{
    public HassInputSelectUpdate(string id, string? name, IEnumerable<string> options, string? initialValue, 
        string? icon) :
        base("input_select/update")
    {
        this.InputSelectId = id;
        this.Name = name;
        this.Options = options?.ToArray();
        this.InitialValue = initialValue;
        this.Icon = icon;
    }

    [JsonPropertyName("input_select_id")]
    public string InputSelectId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("options")]
    public string[]? Options { get; init; }

    [JsonPropertyName("initial")]
    public string? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}


