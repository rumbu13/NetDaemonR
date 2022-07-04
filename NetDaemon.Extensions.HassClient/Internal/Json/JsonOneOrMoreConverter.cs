using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Json;

/// <summary>
/// Reads any collection [v1, v2, ...] and single value v1 as collection [v1] 
/// Writes any collection [v1, v2, ...] and single item collection [v1] as v1 
/// </summary>
/// <typeparam name="T"></typeparam>
public class JsonOneOrMoreConverter<TList, TElement> : JsonConverter<TElement[]>
{
    public override TElement[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.StartArray)
            return JsonSerializer.Deserialize<TElement[]>(ref reader, options);

        var element = JsonSerializer.Deserialize<TElement>(ref reader, options);

#pragma warning disable CS8601 // Possible null reference assignment.
        return new TElement[] { element };
#pragma warning restore CS8601 // Possible null reference assignment.
    }

    public override void Write(Utf8JsonWriter writer, TElement[] value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, options);
    }
}
