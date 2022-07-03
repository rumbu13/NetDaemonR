using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.PresenceApp;

public record BleSensorAttributes
{
    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; set; }

    [JsonPropertyName("mac")]
    public string? MacAddress { get; set; }

    [JsonPropertyName("distance")]
    public double? Distance { get; set; }

    [JsonPropertyName("nearest")]
    public string? Nearest { get; set; }

    [JsonPropertyName("rssi_office")]
    public int? RSSIOffice { get; set; }

    [JsonPropertyName("rssi_bedroom")]
    public int? RSSIBedroom { get; set; }

    [JsonPropertyName("rssi_child_room")]
    public int? RSSIChildRoom { get; set; }

    [JsonPropertyName("rssi_tech_room")]
    public int? RSSITechRoom { get; set; }

    [JsonPropertyName("rssi_kitchen")]
    public int? RSSIKitchen { get; set; }

    [JsonPropertyName("rssi_living_room")]
    public int? RSSILivingRoom { get; set; }

    [JsonPropertyName("rssi_living_room_2")]
    public int? RSSILivingRoom2 { get; set; }

    [JsonPropertyName("rssi_shed")]
    public int? RSSIShed { get; set; }
}
