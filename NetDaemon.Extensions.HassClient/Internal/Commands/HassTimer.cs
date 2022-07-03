using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassTimerList : HassCommand
{
    public HassTimerList() : 
        base("timer/list")
    {            
    }
}

internal record HassTimerCreate : HassCommand
{
    public HassTimerCreate(string name, string? icon, TimeSpan? duration, bool? restore) : 
        base("timer/create")
    {
        this.Name = name;
        this.Icon = icon;
        this.Duration = duration;
        this.Restore = restore;
    }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("duration")]
    public TimeSpan? Duration { get; init; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; init; }

}

internal record HassTimerDelete : HassCommand
{
    public HassTimerDelete(string id) : 
        base("timer/delete")
    {
        this.TimerId = id;
    }

    [JsonPropertyName("timer_id")]
    public string TimerId { get; init; }
}


internal record HassTimerUpdate : HassCommand
{
    public HassTimerUpdate(string id, string? name, string? icon, TimeSpan? duration, bool? restore) :
        base("timer/update")
    {
        this.TimerId = id;
        this.Name = name;
        this.Icon = icon;
        this.Duration = duration;
        this.Restore = restore;
    }

    [JsonPropertyName("timer_id")]
    public string TimerId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("duration")]
    public TimeSpan? Duration { get; init; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; init; }
}


