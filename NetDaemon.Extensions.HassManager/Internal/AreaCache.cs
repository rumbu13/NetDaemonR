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
    internal class AreaCache : Cache<HassArea, Area>
    {
        public AreaCache(IHomeAssistantConnection connection) : base(connection)
        {

        }

        protected override async Task<Dictionary<string, HassArea>> LoadCacheAsync()
        {
            var items = await connection.GetAreasAsync().ConfigureAwait(false);
            return items?.ToDictionary(i => i.Id!) ?? new Dictionary<string, HassArea>();
        }

        public async Task RenameAreaAsync(Area area, string newName)
        {
            var hassArea = await connection.UpdateAreaAsync(area.Id, newName).ConfigureAwait(false);
            Update(area.Id, hassArea!, area);
        }

        public async Task UpdatePictureAsync(Area area, string newPicture)
        {
            var hassArea = await connection.UpdateAreaAsync(area.Id, null, newPicture).ConfigureAwait(false); 
            Update(area.Id, hassArea!, area);
        }

        public async Task<Area> CreateAreaAsync(string name, string? picture = null)
        {
            var hassArea = await connection.CreateAreaAsync(name, picture).ConfigureAwait(false);
            var area = new Area(this, hassArea!);            
            Append(hassArea!.Id!, hassArea, area);
            return area;
        }

        public async Task RemoveAreaAsync(Area area)
        {
            await connection.DeleteAreaAsync(area.Id).ConfigureAwait(false);
            Remove(area.Id);
        }
    }
}
