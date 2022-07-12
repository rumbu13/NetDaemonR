using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Extensions.HassClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassInputTextList : HassCommand
{
    public HassInputTextList() : 
        base("input_text/list")
    {            
    }
}

internal record HassInputTextCreate : HassCommand
{
    public HassInputTextCreate(string name, int? minLength, int? maxLength, string? initialValue, string? icon, 
        string? unitOfMeasurement, string? pattern, HassInputTextMode? mode) : 
        base("input_text/create")
    {
        this.Name = name;
        this.MinLength = minLength;
        this.MaxLength = maxLength;
        this.InitialValue = initialValue;
        this.Icon = icon;
        this.UnitOfMeasurement = unitOfMeasurement;
        this.Pattern = pattern;
        this.Mode = mode;
    }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("min")]
    public int? MinLength { get; init; }

    [JsonPropertyName("max")]
    public int? MaxLength { get; init; }

    [JsonPropertyName("initial")]
    public string? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }

    [JsonPropertyName("pattern")]
    public string? Pattern { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("mode")]
    public HassInputTextMode? Mode { get; init; }
}

internal record HassInputTextDelete : HassCommand
{
    public HassInputTextDelete(string id) : 
        base("input_text/delete")
    {
        this.InputTextId = id;
    }

    [JsonPropertyName("input_text_id")]
    public string InputTextId { get; init; }
}


internal record HassInputTextUpdate : HassCommand
{
    public HassInputTextUpdate(string id, string? name, int? minLength, int? maxLength, string? initialValue, 
        string? icon, string? unitOfMeasurement, string? pattern, HassInputTextMode? mode) :
        base("input_text/update")
    {
        this.InputTextId = id;
        this.Name = name;
        this.MinLength = minLength;
        this.MaxLength = maxLength;
        this.InitialValue = initialValue;
        this.Icon = icon;
        this.UnitOfMeasurement = unitOfMeasurement;
        this.Pattern = pattern;
        this.Mode = mode;
    }

    [JsonPropertyName("input_text_id")]
    public string InputTextId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("min")]
    public int? MinLength { get; init; }

    [JsonPropertyName("max")]
    public int? MaxLength { get; init; }

    [JsonPropertyName("initial")]
    public string? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }

    [JsonPropertyName("pattern")]
    public string? Pattern { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("mode")]
    public HassInputTextMode? Mode { get; init; }
}


