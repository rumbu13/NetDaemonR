
using System.Runtime.Serialization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;


public record HassBlueprint
{
    [JsonPropertyName("metadata")]
    public HassBlueprintMetadata? Metadata { get; init; }
}

public record HassBlueprintMetadata
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("domain")]
    public HassBlueprintDomain? Domain { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("source_url")]
    public string? SourceUrl { get; init; }

    [JsonPropertyName("input")]
    public Dictionary<string, HassBlueprintInput>? Input { get; init; }
}

public record HassBlueprintImportResult
{
    [JsonPropertyName("suggested_filename")]
    public string? SuggestedFilename { get; init; }

    [JsonPropertyName("raw_data")]
    public string? RawData { get; init; }

    [JsonPropertyName("suggested_filename")]
    public HassBlueprint? Blueprint { get; init; }

    [JsonPropertyName("validation_errors")]
    public string[]? ValidationErrors { get; init; }
}

public enum HassBlueprintDomain
{
    [EnumMember(Value = "automation")]
    Automation,
    [EnumMember(Value = "script")]
    Script
}

public record HassBlueprintInput
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("selector")]
    public HassBlueprintSelector? Selector { get; init; }
}

public record HassBlueprintSelector
{
    [JsonPropertyName("action")]
    public JsonObject? Action { get; init; }

    [JsonPropertyName("addon")]
    public JsonObject? Addon { get; init; }

    [JsonPropertyName("area")]
    public JsonObject? Area { get; init; }

    [JsonPropertyName("attribute")]
    public JsonObject? Attribute { get; init; }

    [JsonPropertyName("boolean")]
    public JsonObject? Boolean { get; init; }

    [JsonPropertyName("color_rgb")]
    public JsonObject? ColorRgb { get; init; }

    [JsonPropertyName("color_temp")]
    public JsonObject? ColorTemperature { get; init; }

    [JsonPropertyName("date")]
    public JsonObject? Date { get; init; }

    [JsonPropertyName("datetime")]
    public JsonObject? DateTime { get; init; }

    [JsonPropertyName("device")]
    public JsonObject? Device { get; init; }

    [JsonPropertyName("duration")]
    public JsonObject? Duration { get; init; }

    [JsonPropertyName("entity")]
    public JsonObject? Entity { get; init; }

    [JsonPropertyName("icon")]
    public JsonObject? Icon { get; init; }

    [JsonPropertyName("location")]
    public JsonObject? Location { get; init; }

    [JsonPropertyName("latitude")]
    public double? Latitude { get; init; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; init; }

    [JsonPropertyName("radius")]
    public double? Radius { get; init; }

    [JsonPropertyName("media")]
    public JsonObject? Media { get; init; }

    [JsonPropertyName("entity_id")]
    public string? MediaEntityId { get; init; }

    [JsonPropertyName("media_content_id")]
    public string? MediaContentId { get; init; }

    [JsonPropertyName("media_content_type")]
    public string? MediaContentType { get; init; }

    [JsonPropertyName("metadata")]
    public JsonObject? MediaMetadata { get; init; }

    [JsonPropertyName("number")]
    public JsonObject? Number { get; init; }

    [JsonPropertyName("object")]
    public JsonObject? Object { get; init; }

    [JsonPropertyName("value")]
    public string? OptionValue { get; init; }

    [JsonPropertyName("label")]
    public string? OptionLabel { get; init; }

    [JsonPropertyName("select")]
    public JsonObject? Select { get; init; }

    [JsonPropertyName("text")]
    public JsonObject? Text { get; init; }

    [JsonPropertyName("target")]
    public JsonObject? Target { get; init; }

    [JsonPropertyName("template")]
    public JsonObject? Template { get; init; }

    [JsonPropertyName("theme")]
    public JsonObject? Theme { get; init; }

    [JsonPropertyName("time")]
    public JsonObject? Time { get; init; }
}

