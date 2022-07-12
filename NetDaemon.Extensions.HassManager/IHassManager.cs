using NetDaemon.Extensions.HassManager.Models;

namespace NetDaemon.Extensions.HassManager;

public interface IHassManager
{
    IEnumerable<Area> GetAreas();
    Area? GetArea(string id);
    

}