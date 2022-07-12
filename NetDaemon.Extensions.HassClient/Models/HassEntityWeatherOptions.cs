namespace NetDaemon.Extensions.HassClient.Models;

public record HassEntityWeatherOptions
{
    [JsonPropertyName("precipitation_unit")]
    public string? PrecipitationUnit { get; init; }

    [JsonPropertyName("pressure_unit")]
    public string? PressureUnitUnit { get; init; }

    [JsonPropertyName("temperature_unit")]
    public string? TemperatureUnit { get; init; }

    [JsonPropertyName("visibility_unit")]
    public string? VisibilityUnit { get; init; }

    [JsonPropertyName("wind_speed_unit")]
    public string? WindSpeedUnit { get; init; }
}

