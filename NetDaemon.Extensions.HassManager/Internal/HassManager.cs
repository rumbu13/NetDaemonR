using NetDaemon.Client;
using NetDaemon.Extensions.HassClient.Models;
using NetDaemon.Extensions.HassManager.Models;
using NetDaemon.Extensions.HassClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassManager.Internal
{
    internal class HassManager
    {
        readonly IHomeAssistantConnection connection;
        Cache<HassArea, Area> areaCache;
        public HassManager(IHomeAssistantConnection connection)
        {
            this.connection = connection;
            this.areaCache = new AreaCache(connection);
        }

        public IEnumerable<Area> GetAreas()
        {
            return areaCache.Get();
        }
        public Area? GetArea(string id)
        {
            return areaCache.Get(id);
        }


    }
}
