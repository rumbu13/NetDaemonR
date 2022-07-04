using NetDaemon.Extensions.HassClient.Models;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassDeviceAutomationActionList : HassCommand
{
    public HassDeviceAutomationActionList(string id) :
        base("device_automation/action/list")
    {
        this.DeviceId = id;
    }
    [JsonPropertyName("device_id")]
    public string DeviceId { get; init; }
}

internal record HassDeviceAutomationConditionList : HassCommand
{
    public HassDeviceAutomationConditionList(string id) :
        base("device_automation/condition/list")
    {
        this.DeviceId = id;
    }
    [JsonPropertyName("device_id")]
    public string DeviceId { get; init; }
}


internal record HassDeviceAutomationTriggerList : HassCommand
{
    public HassDeviceAutomationTriggerList(string id) :
        base("device_automation/trigger/list")
    {
        this.DeviceId = id;
    }
    [JsonPropertyName("device_id")]
    public string DeviceId { get; init; }
}

internal record HassDeviceAutomationActionCapabilities : HassCommand
{
    public HassDeviceAutomationActionCapabilities(HassDeviceAction action) :
        base("device_automation/action/capabilities")
    {
        this.Action = action;
    }
    [JsonPropertyName("action")]
    public HassDeviceAction Action { get; init; }
}

internal record HassDeviceAutomationConditionCapabilities : HassCommand
{
    public HassDeviceAutomationConditionCapabilities(HassDeviceCondition condition) :
        base("device_automation/condition/capabilities")
    {
        this.Condition = condition;
    }
    [JsonPropertyName("condition")]
    public HassDeviceCondition Condition { get; init; }
}


internal record HassDeviceAutomationTriggerCapabilities : HassCommand
{
    public HassDeviceAutomationTriggerCapabilities(HassDeviceTrigger trigger) :
        base("device_automation/trigger/capabilities")
    {
        this.Trigger = trigger;
    }
    [JsonPropertyName("trigger")]
    public HassDeviceTrigger Trigger { get; init; }
}




