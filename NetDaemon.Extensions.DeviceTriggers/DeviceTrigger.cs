using NetDaemon.Extensions.HassClient.Models;

namespace NetDaemon.Extensions.DeviceTriggers
{

    public class DeviceTrigger
    {
        HassDevice device;
        HassArea? area;
        HassDeviceAutomationTrigger trigger;

        internal DeviceTrigger(HassDevice device, HassArea? area, HassDeviceAutomationTrigger trigger)
        {
            this.device = device;
            this.area = area;
            this.trigger = trigger;
        }



        /// <summary>
        /// type of trigger, e.g. "action", "button_press"
        /// </summary>
        public string? Type
            => trigger.Type;

        /// <summary>
        /// subtype of trigger, e.g. "turn_on", "off"
        /// </summary>
        public string? Subtype
            => trigger.Subtype;

        /// <summary>
        /// Unique id reported by mqtt autodiscovery
        /// </summary>
        public string? DiscoveryId
            => trigger.DiscoveryId;

        /// <summary>
        /// Device unique identifier
        /// </summary>
        public string? DeviceId
            => trigger.DeviceId;

        /// <summary>
        /// Device name
        /// </summary>
        public string? DeviceName
            => device.NameByUser ?? device.Name;

        /// <summary>
        /// Device model
        /// </summary>
        public string? DeviceModel
            => device.Model;

        /// <summary>
        /// Device manufacturer
        /// </summary>
        public string? DeviceManufacturer
            => device.Manufacturer;

        /// <summary>
        /// Area associated with the triggered device
        /// </summary>
        public string? AreaId
            => area?.Id;

        /// <summary>
        /// Name of the area associated with the triggered device
        /// </summary>
        public string? AreaName
            => area?.Name;        

    }
}
