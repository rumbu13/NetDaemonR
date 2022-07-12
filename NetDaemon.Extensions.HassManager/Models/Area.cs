using NetDaemon.Extensions.HassClient.Models;
using NetDaemon.Extensions.HassManager.Internal;

namespace NetDaemon.Extensions.HassManager.Models
{
    public class Area
    {
        AreaCache cache;
        HassArea hassArea;

        internal Area(AreaCache cache, HassArea area)
        {
            this.cache = cache;
            this.hassArea = area;            
        }

        public string Id
            => hassArea.Id!;

        public string Name
        {
            get => hassArea.Name!;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Area name cannot be empty");
                if (value != hassArea.Name)
                    cache.RenameAreaAsync(this, value).Wait();
            }
        }

        public string? Picture
        {
            get => hassArea.Picture;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    value = String.Empty;
                if (value != hassArea.Picture)
                    cache.UpdatePictureAsync(this, value).Wait();
            }
        }

        public void Delete()
        {
            cache.RemoveAreaAsync(this).Wait();
        }
    }
}