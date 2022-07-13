using NetDaemon.Extensions.HassClient.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Json;


internal class JsonDeviceIdentifierConverter : JsonConverter<HassDeviceIdentifier>
{
    public override HassDeviceIdentifier Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();
        reader.Read();
        string? domain = null;
        string? identifier = null;

        if (reader.TokenType == JsonTokenType.String)
        {
            domain = reader.GetString();
            reader.Read();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            identifier = reader.GetString();
            reader.Read();
        }

        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();
        return new HassDeviceIdentifier()
        {
            Domain = domain,
            Identifier = identifier,
        };
    }

    public override void Write(Utf8JsonWriter writer, HassDeviceIdentifier value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteStringValue(value.Domain);
        writer.WriteStringValue(value.Identifier);
        writer.WriteEndArray();
    }
}

internal class JsonDeviceIdentifiersConverter : JsonConverter<IEnumerable<HassDeviceIdentifier>>
{

    public override IEnumerable<HassDeviceIdentifier>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var converter = new JsonDeviceIdentifierConverter();
        var items = new List<HassDeviceIdentifier>();
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();
        reader.Read();
        while (reader.TokenType != JsonTokenType.EndArray)
        {
            items.Add(converter.Read(ref reader, typeof(HassDeviceIdentifier), options));
            reader.Read();
        }        
        return items;
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<HassDeviceIdentifier> value, JsonSerializerOptions options)
    {
        var converter = new JsonDeviceIdentifierConverter();
        writer.WriteStartArray();
        foreach (var item in value)
            converter.Write(writer, item, options);
        writer.WriteEndArray();
    }
}
