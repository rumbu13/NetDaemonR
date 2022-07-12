namespace NetDaemon.Extensions.HassClient.Models;

public record HassInputText
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("min")]
    public int? MinLength { get; init; }

    [JsonPropertyName("max")]
    public int? MaxLength { get; init; }

    [JsonPropertyName("initial")]
    public string? InitialValue { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }

    [JsonPropertyName("pattern")]
    public string? Pattern { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("mode")]
    public HassInputTextMode? Mode { get; init; }

}


