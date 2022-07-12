using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassInputDateTimeList : HassCommand
{
    public HassInputDateTimeList() : 
        base("input_datetime/list")
    {            
    }
}

internal record HassInputDateTimeCreate : HassCommand
{
    public HassInputDateTimeCreate(string name, bool? hasDate, bool? hasTime, string? icon, DateTime? initialValue) : 
        base("input_datetime/create")
    {
        this.Name = name;
        this.HasDate = hasDate;
        this.HasTime = hasTime;
        this.Icon = icon;
        this.InitialValue = initialValue;
    }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("has_date")]
    public bool? HasDate { get; init; }

    [JsonPropertyName("has_time")]
    public bool? HasTime { get; init; }

    [JsonPropertyName("initial")]
    public DateTime? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}

internal record HassInputDateTimeDelete : HassCommand
{
    public HassInputDateTimeDelete(string id) : 
        base("input_datetime/delete")
    {
        this.InputDateTimeId = id;
    }

    [JsonPropertyName("input_datetime_id")]
    public string InputDateTimeId { get; init; }
}


internal record HassInputDateTimeUpdate : HassCommand
{
    public HassInputDateTimeUpdate(string id, string? name, bool? hasDate, bool? hasTime, string? icon, 
        DateTime? initialValue) :
        base("input_datetime/update")
    {
        this.InputDateTimeId = id;
        this.Name = name;
        this.HasDate = hasDate;
        this.HasTime = hasTime;
        this.Icon = icon;
        this.InitialValue = initialValue;
    }

    [JsonPropertyName("input_datetime_id")]
    public string InputDateTimeId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("has_date")]
    public bool? HasDate { get; init; }

    [JsonPropertyName("has_time")]
    public bool? HasTime { get; init; }

    [JsonPropertyName("initial")]
    public DateTime? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}


