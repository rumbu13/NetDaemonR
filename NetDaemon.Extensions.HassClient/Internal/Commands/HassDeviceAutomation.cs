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

internal record HassDeviceAutomationTriggerSubscribe : HassCommand
{
    public HassDeviceAutomationTriggerSubscribe(HassDeviceAutomationTrigger trigger) :
        base("subscribe_trigger")
    {
        Trigger = trigger;
    }

    [JsonPropertyName("trigger")]
    public HassDeviceAutomationTrigger Trigger { get; init; }
}

internal record HassDeviceAutomationTriggerUnsubscribe : HassCommand
{
    public HassDeviceAutomationTriggerUnsubscribe(int id) :
        base("unsubscribe_events")
    {
        SubscriptionId = id;
    }

    [JsonPropertyName("subscription")]
    public int SubscriptionId { get; init; }
}






