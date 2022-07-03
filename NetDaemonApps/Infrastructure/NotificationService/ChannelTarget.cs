using System.ComponentModel;
using System.Threading.Tasks;

namespace NetDaemonApps.Infrastructure;

public enum ChannelTarget
{
    [Description("981306044653391894")]
    General,

    [Description("983231244814925825")]
    State,

    [Description("983117987030646804")]
    Camera,

    [Description("983117520594690138")]
    Alarm
}

