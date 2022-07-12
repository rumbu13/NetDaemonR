namespace NetDaemon.Extensions.HassClient.Models;

public enum HassEntityCategory
{
    [EnumMember(Value="config")]
    Configuration,
    [EnumMember(Value = "diagnostic")]
    Diagnostic
}