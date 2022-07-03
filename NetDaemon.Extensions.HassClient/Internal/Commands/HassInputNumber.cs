using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Extensions.HassClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassInputNumberList : HassCommand
{
    public HassInputNumberList() : 
        base("counter/list")
    {            
    }
}

internal record HassInputNumberCreate : HassCommand
{
    public HassInputNumberCreate(string name, double min, double max, double? initialValue, double? step, string? icon,
        string? unitOfMeasurement, HassInputNumberMode? mode) : 
        base("counter/create")
    {
        this.Name = name;
        this.Min = min;
        this.Max = max;
        this.InitialValue = initialValue;
        this.Step = step;
        this.Icon = icon;   
        this.UnitOfMeasurement = unitOfMeasurement;
        this.Mode = mode;
    }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("min")]
    public double Min { get; init; }

    [JsonPropertyName("max")]
    public double Max { get; init; }

    [JsonPropertyName("initial")]
    public double? InitialValue { get; init; }

    [JsonPropertyName("step")]
    public double? Step { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
        
    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }

    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public HassInputNumberMode? Mode { get; init; }
}

internal record HassInputNumberDelete : HassCommand
{
    public HassInputNumberDelete(string id) : 
        base("counter/delete")
    {
        this.InputNumberId = id;
    }

    [JsonPropertyName("counter_id")]
    public string InputNumberId { get; init; }
}


internal record HassInputNumberUpdate : HassCommand
{
    public HassInputNumberUpdate(string id, string? name, double? min, double? max, double? initialValue, double? step, 
        string? icon, string? unitOfMeasurement, HassInputNumberMode? mode) :
        base("counter/update")
    {
        this.InputNumberId = id;
        this.Name = name;
        this.Min = min;
        this.Max = max;
        this.InitialValue = initialValue;
        this.Step = step;
        this.Icon = icon;
        this.UnitOfMeasurement = unitOfMeasurement;
        this.Mode = mode;
    }

    [JsonPropertyName("counter_id")]
    public string InputNumberId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("min")]
    public double? Min { get; init; }

    [JsonPropertyName("max")]
    public double? Max { get; init; }

    [JsonPropertyName("initial")]
    public double? InitialValue { get; init; }

    [JsonPropertyName("step")]
    public double? Step { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }

    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public HassInputNumberMode? Mode { get; init; }
}


