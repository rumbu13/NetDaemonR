using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.VacuumApp
{
    public record RoomInfoAttributes
    {
        [JsonPropertyName("is_cleaning")]
        public bool? IsCleaning { get; init; }

        [JsonPropertyName("has_error")]
        public bool? HasError { get; init; }
    }
}
