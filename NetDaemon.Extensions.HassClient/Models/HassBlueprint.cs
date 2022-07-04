
using NetDaemon.Extensions.HassClient.Internal.Json;
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
    public HassSelector? Selector { get; init; }
}

