using System.ComponentModel;
using System.Threading.Tasks;

namespace NetDaemonApps.Infrastructure;

public enum TVTarget
{
    [Description("living_room")]
    LivingRoom,

    [Description("child_room")]
    ChildRoom,

    All,
}

