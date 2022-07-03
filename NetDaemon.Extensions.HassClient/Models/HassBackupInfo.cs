
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;


public record HassBackupInfo
{
    [JsonPropertyName("backups")]
    public HassBackup[]? Backups { get; init; }

    [JsonPropertyName("backing_up")]
    public bool? IsBackingUp { get; set; }
}

