using System.ComponentModel;
using System.Threading.Tasks;

namespace NetDaemonApps.Infrastructure;

public enum SpeakerTarget
{
    [Description("living_room")]
    LivingRoom,  
    
    All,
}

