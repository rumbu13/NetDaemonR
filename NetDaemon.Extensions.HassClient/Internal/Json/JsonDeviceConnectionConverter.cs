using NetDaemon.Extensions.HassClient.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Json;


internal class JsonDeviceConnectionConverter : JsonConverter<HassDeviceConnection>
{
    public override HassDeviceConnection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();
        reader.Read();
        string? connection = reader.GetString();
        reader.Read();
        string? identifier = reader.GetString();
        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();
        return new HassDeviceConnection()
        {
            ConnectionType = connection,
            Identifier = identifier,
        };
    }

    public override void Write(Utf8JsonWriter writer, HassDeviceConnection value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteStringValue(value.ConnectionType);
        writer.WriteStringValue(value.Identifier);
        writer.WriteEndArray();
    }
}

internal class JsonDeviceConnectionsConverter : JsonConverter<IEnumerable<HassDeviceConnection>>
{

    public override IEnumerable<HassDeviceConnection>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var converter = new JsonDeviceConnectionConverter();
        var items = new List<HassDeviceConnection>();
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();
        reader.Read();
        while (reader.TokenType != JsonTokenType.EndArray)
        {
            items.Add(converter.Read(ref reader, typeof(HassDeviceConnection), options));
            reader.Read();
        }        
        return items;
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<HassDeviceConnection> value, JsonSerializerOptions options)
    {
        var converter = new JsonDeviceConnectionConverter();
        writer.WriteStartArray();
        foreach (var item in value)
            converter.Write(writer, item, options);
        writer.WriteEndArray();
    }
}
