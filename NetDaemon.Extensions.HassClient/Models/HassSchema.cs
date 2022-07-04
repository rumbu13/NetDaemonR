using NetDaemon.Extensions.HassClient.Internal.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassSchema
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("default")]
    public Object? Default { get; init; }

    [JsonPropertyName("required")]
    public bool? Required { get; init; }

    [JsonPropertyName("description")]
    public HassSchemaDescription? Description { get; init; }

    [JsonPropertyName("context")]
    public IDictionary<string, string>? Context { get; init; }

    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("selector")]
    public HassSelector? Selector { get; init; }

    [JsonPropertyName("value")]
    public string? Value { get; init; }

    [JsonPropertyName("valueMin")]
    public double? ValueMin { get; init; }

    [JsonPropertyName("valueMax")]
    public double? ValueMax { get; init; }

    [JsonPropertyName("options")]
    public Object? Options { get; init; }

    [JsonPropertyName("format")]
    public string? Format { get; init; }
}



public record HassSchemaDescription
{
    [JsonPropertyName("suffix")]
    public string? Suffix { get; init; }

    [JsonPropertyName("suggested_value")]
    public Object? SuggestedValue { get; init; }
}