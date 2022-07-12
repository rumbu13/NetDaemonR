using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassCounterList : HassCommand
{
    public HassCounterList() : 
        base("counter/list")
    {            
    }
}

internal record HassCounterCreate : HassCommand
{
    public HassCounterCreate(string name, string? icon, int? initialValue, int? step, int? minimum, int? maximum, 
        bool? restore) : 
        base("counter/create")
    {
        this.Name = name;
        this.Icon = icon;
        this.InitialValue = initialValue;
        this.Step = step;
        this.Minimum = minimum;
        this.Maximum = maximum;
        this.Restore = restore;
    }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("initial")]
    public int? InitialValue { get; init; }

    [JsonPropertyName("step")]
    public int? Step { get; init; }

    [JsonPropertyName("minimum")]
    public int? Minimum { get; init; }

    [JsonPropertyName("maximum")]
    public int? Maximum { get; init; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; init; }
}

internal record HassCounterDelete : HassCommand
{
    public HassCounterDelete(string id) : 
        base("counter/delete")
    {
        this.CounterId = id;
    }

    [JsonPropertyName("counter_id")]
    public string CounterId { get; init; }
}


internal record HassCounterUpdate : HassCommand
{
    public HassCounterUpdate(string id, string? name, string? icon, int? initialValue, int? step, int? minimum, 
        int? maximum, bool? restore) :
        base("counter/update")
    {
        this.CounterId = id;
        this.Name = name;
        this.Icon = icon;
        this.InitialValue = initialValue;
        this.Step = step;
        this.Minimum = minimum;
        this.Maximum = maximum;
        this.Restore = restore;
    }

    [JsonPropertyName("counter_id")]
    public string CounterId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("initial")]
    public int? InitialValue { get; init; }

    [JsonPropertyName("step")]
    public int? Step { get; init; }

    [JsonPropertyName("minimum")]
    public int? Minimum { get; init; }

    [JsonPropertyName("maximum")]
    public int? Maximum { get; init; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; init; }
}


