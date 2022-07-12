namespace NetDaemon.Extensions.HassClient.Models;

public record HassEntitySensorOptions
{
    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }
}

