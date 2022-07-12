using NetDaemon.Client;
using NetDaemon.Extensions.HassClient;
using NetDaemon.Extensions.HassClient.Models;
using NetDaemon.Extensions.HassManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassManager.Internal
{
    internal class DeviceCache : Cache<HassDevice, Device>
    {
        public DeviceCache(IHomeAssistantConnection connection) : base(connection)
        {

        }

        protected override async Task<Dictionary<string, HassDevice>> LoadCacheAsync()
        {
            var items = await connection.GetDevicesAsync().ConfigureAwait(false);
            return items?.ToDictionary(i => i.Id!) ?? new Dictionary<string, HassDevice>();
        }

        //public async Task RenameDeviceAsync(Device device, string newName)
        //{
        //    var hassDevice = await connection.UpdateDeviceAsync(device.Id, newName).ConfigureAwait(false);
        //    Update(device.Id, hassDevice!, device);
        //}

        //public async Task UpdatePictureAsync(Device device, string newPicture)
        //{
        //    var hassDevice = await connection.UpdateDeviceAsync(device.Id, null, newPicture).ConfigureAwait(false); 
        //    Update(device.Id, hassDevice!, device);
        //}

        //public async Task<Device> CreateDeviceAsync(string name, string? picture = null)
        //{
        //    var hassDevice = await connection.CreateDeviceAsync(name, picture).ConfigureAwait(false);
        //    var device = new Device(this, hassDevice!);            
        //    Append(hassDevice!.Id!, hassDevice, device);
        //    return device;
        //}

        //public async Task RemoveDeviceAsync(Device device)
        //{
        //    await connection.DeleteDeviceAsync(device.Id).ConfigureAwait(false);
        //    Remove(device.Id);
        //}
    }
}
