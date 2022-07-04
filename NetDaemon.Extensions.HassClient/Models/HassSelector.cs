
using NetDaemon.Extensions.HassClient.Internal.Json;
using System.Runtime.Serialization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Models;


public record HassSelector
{
    [JsonPropertyName("action")]
    public JsonObject? Action { get; init; }

    [JsonPropertyName("addon")]
    public HassAddonObject? Addon { get; init; }

    [JsonPropertyName("area")]
    public HassAreaObject? Area { get; init; }

    [JsonPropertyName("attribute")]
    public HassAttributeObject? Attribute { get; init; }

    [JsonPropertyName("boolean")]
    public JsonObject? Boolean { get; init; }

    [JsonPropertyName("color_rgb")]
    public JsonObject? ColorRgb { get; init; }

    [JsonPropertyName("color_temp")]
    public HassColorTempObject? ColorTemp { get; init; }

    [JsonPropertyName("date")]
    public JsonObject? Date { get; init; }

    [JsonPropertyName("datetime")]
    public JsonObject? DateTime { get; init; }

    [JsonPropertyName("device")]
    public HassDeviceObject? Device { get; init; }

    [JsonPropertyName("duration")]
    public HassDurationObject? Duration { get; init; }

    [JsonPropertyName("entity")]
    public HassEntityObject? Entity { get; init; }

    [JsonPropertyName("icon")]
    public HassIconObject? Icon { get; init; }

    [JsonPropertyName("location")]
    public HassLocationObject? Location { get; init; }

    [JsonPropertyName("media")]
    public JsonObject? Media { get; init; }

    [JsonPropertyName("number")]
    public HassNumberObject? Number { get; init; }

    [JsonPropertyName("object")]
    public JsonObject? Object { get; init; }

    [JsonPropertyName("select")]
    public HassSelectObject? Select { get; init; }

    [JsonPropertyName("text")]
    public HassTextObject? Text { get; init; }

    [JsonPropertyName("target")]
    public HassTargetObject? Target { get; init; }

    [JsonPropertyName("template")]
    public JsonObject? Template { get; init; }

    [JsonPropertyName("theme")]
    public JsonObject? Theme { get; init; }

    [JsonPropertyName("time")]
    public JsonObject? Time { get; init; }
}

public class HassColorTempObject
{
    [JsonPropertyName("min_mireds")]
    public double? MinMireds { get; init; }

    [JsonPropertyName("max_mireds")]
    public double? MaxMireds { get; init; }
}

public class HassDeviceObject
{
    [JsonPropertyName("integration")]
    public string? Integration { get; init; }

    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; init; }

    [JsonPropertyName("model")]
    public string? Model { get; init; }

    [JsonPropertyName("entity")]
    public HassEntityObject? Entity { get; init; }

    [JsonPropertyName("multiple")]
    public bool? Multiple { get; init; }
}

public class HassEntityObject
{
    [JsonConverter(typeof(JsonOneOrMoreConverter<string[], string>))]
    [JsonPropertyName("domain")]
    public string[]? Domain { get; init; }

    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("multiple")]
    public bool? Multiple { get; init; }

    [JsonPropertyName("include_entities")]
    public string[]? IncludeEntities { get; init; }

    [JsonPropertyName("exclude_entities")]
    public string[]? ExcludeEntities { get; init; }

}

public class HassDurationObject
{
    [JsonPropertyName("enable_day")]
    public bool? EnableDay { get; init; }
}

public class HassIconObject
{
    [JsonPropertyName("placeholder")]
    public string? PlaceHolder { get; init; }

    [JsonPropertyName("fallbackPath")]
    public string? FallbackPath { get; init; }
}

public class HassLocationObject
{
    [JsonPropertyName("radius")]
    public bool? Radius { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}

public class HassNumberObject
{
    [JsonPropertyName("min")]
    public double? Min { get; init; }

    [JsonPropertyName("max")]
    public double? Max { get; init; }

    [JsonPropertyName("step")]
    public double? Step { get; init; }

    [JsonPropertyName("mode")]
    public HassInputNumberMode? Mode { get; init; }

    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }
}

public record HassSelectObject
{
    [JsonPropertyName("multiple")]
    public bool? Multiple { get; init; }

    [JsonPropertyName("custom_value")]
    public bool? CustomValue { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("mode")]
    public HassSelectSelectorMode? Mode { get; init; }

    [JsonPropertyName("options")]
    public string[]? Options { get; init; }

}

public record HassSelectorOption
{
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    [JsonPropertyName("label")]
    public string? Label { get; init; }
}

public class HassTextObject
{
    [JsonPropertyName("multiline")]
    public bool? Multiline { get; init; }

    [JsonPropertyName("type")]
    public HassStringSelectorType? Type { get; init; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; init; }
}

public class HassTargetObject
{
    [JsonPropertyName("entity")]
    public HassEntityObject? Entity { get; init; }

    [JsonPropertyName("device")]
    public HassDeviceObject? Device { get; init; }
}


public class HassAttributeObject
{
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }
}

public class HassAddonObject
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("slug")]
    public string? Slug { get; init; }
}

public record HassAreaObject
{
    [JsonPropertyName("entity")]
    public HassEntityObject? Entity { get; init; }

    [JsonPropertyName("device")]
    public HassDeviceObject? Device { get; init; }

    [JsonPropertyName("multiple")]
    public bool? Multiple { get; init; }
}

public enum HassSelectSelectorMode
{
    [EnumMember(Value = "list")]
    List,
    [EnumMember(Value = "dropdown")]
    Dropdown,
}

public enum HassStringSelectorType
{
    [EnumMember(Value = "number")]
    Number,
    [EnumMember(Value = "text")]
    Text,
    [EnumMember(Value = "search")]
    Search,
    [EnumMember(Value = "tel")]
    Telephone,
    [EnumMember(Value = "url")]
    Url,
    [EnumMember(Value = "email")]
    Email,
    [EnumMember(Value = "password")]
    Password,
    [EnumMember(Value = "date")]
    Date,
    [EnumMember(Value = "month")]
    Month,
    [EnumMember(Value = "week")]
    Week,
    [EnumMember(Value = "time")]
    Time,
    [EnumMember(Value = "datetime-local")]
    DateTimeLocal,
    [EnumMember(Value = "color")]
    Color
}