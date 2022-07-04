using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassDeviceList : HassCommand
{
    public HassDeviceList() : 
        base("config/device_registry/list")
    {            
    }
}

internal record HassDeviceRemoveConfig : HassCommand
{
    public HassDeviceRemoveConfig(string id, string configEntryId) : 
        base("config/device_registry/remove_config_entry")
    {
        this.DeviceId = id;
        this.ConfigEntryId = configEntryId;
    }

    [JsonPropertyName("device_id")]
    public string DeviceId { get; init; }

    [JsonPropertyName("config_entry_id")]
    public string ConfigEntryId { get; init; }
}


internal record HassDeviceUpdate : HassCommand
{
    public HassDeviceUpdate(string id, string? areaId, string? nameByUser, string? disabledBy) : 
        base("config/device_registry/update")
    {
        this.DeviceId = id;
        this.AreaId = areaId;
        this.NameByUser = nameByUser;
        this.DisabledBy = disabledBy;
    }

    [JsonPropertyName("device_id")]
    public string DeviceId { get; init; }

    [JsonPropertyName("area_id")]
    public string? AreaId { get; init; }

    [JsonPropertyName("name_by_user")]
    public string? NameByUser { get; init; }

    [JsonPropertyName("disabled_by")]
    public string? DisabledBy { get; init; }

}


