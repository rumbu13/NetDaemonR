using NetDaemon.Extensions.HassClient.Models;
using NetDaemon.Extensions.HassManager.Internal;

namespace NetDaemon.Extensions.HassManager.Models
{
    public class Device
    {
        DeviceCache cache;
        AreaCache areaCache;
        HassDevice hassDevice;

        internal Device(DeviceCache cache, AreaCache areaCache, HassDevice device)
        {
            this.cache = cache;
            this.areaCache = areaCache;
            this.hassDevice = device;            
        }

        public string Id
            => hassDevice.Id!;

        public Area? Area
        {
            get => hassDevice.AreaId != null ? areaCache.Get(hassDevice.AreaId) : null;
            set
            {
                //
            }

        }

        //public string Name
        //{
        //    get => hassDevice.Name!;
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //            throw new ArgumentException("Device name cannot be empty");
        //        if (value != hassDevice.Name)
        //            cache.RenameDeviceAsync(this, value).Wait();
        //    }
        //}

        //public string? Picture
        //{
        //    get => hassDevice.Picture;
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //            value = String.Empty;
        //        if (value != hassDevice.Picture)
        //            cache.UpdatePictureAsync(this, value).Wait();
        //    }
        //}

        //public void Delete()
        //{
        //    cache.RemoveDeviceAsync(this).Wait();
        //}
    }
}