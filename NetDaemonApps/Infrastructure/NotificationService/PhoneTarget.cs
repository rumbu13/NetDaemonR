using System.ComponentModel;
using System.Threading.Tasks;

namespace NetDaemonApps.Infrastructure;

public enum PhoneTarget
{
    [Description("razvan")]
    Razvan,

    [Description("nico")]
    Nico,

    [Description("rares")]
    Rares,

    All,
}

