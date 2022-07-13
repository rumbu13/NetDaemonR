using System.Text.Json;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Json;

/// <summary>
/// Reads bools or numbers as simple string
/// </summary>
internal class JsonAlwaysStringConverter : JsonConverter<string>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.String:
                return reader.GetString();
            case JsonTokenType.True:
            case JsonTokenType.False:
                return reader.GetBoolean().ToString().ToLowerInvariant();
            case JsonTokenType.Number:
                return reader.GetDouble().ToString();
            default:
                throw new JsonException();
        }
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}


