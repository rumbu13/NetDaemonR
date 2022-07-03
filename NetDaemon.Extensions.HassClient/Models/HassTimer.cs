﻿
using NetDaemon.Extensions.HassClient.Internal.Json;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;

public record HassTimer
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonConverter(typeof(TimeSpanDurationJsonConverter))]
    [JsonPropertyName("duration")]
    public TimeSpan? Duration { get; init; }

    [JsonPropertyName("restore")]
    public bool? Restore { get; set; }
}
