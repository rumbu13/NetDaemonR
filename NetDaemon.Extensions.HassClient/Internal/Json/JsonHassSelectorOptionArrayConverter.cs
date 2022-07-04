using NetDaemon.Extensions.HassClient.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Json;

internal class JsonSelectOptionConverter : JsonConverter<HassSelectorOption?>
{
    public override HassSelectorOption? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;
        if (reader.TokenType == JsonTokenType.String)
            return new HassSelectorOption() { Label = null, Value = reader.GetString() };
        else if (reader.TokenType == JsonTokenType.StartObject)
            return JsonSerializer.Deserialize<HassSelectorOption?>(ref reader, options);

        throw new JsonException();

    }

    public override void Write(Utf8JsonWriter writer, HassSelectorOption? value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize<HassSelectorOption?>(writer, value, options);
    }
}

internal class JsonSelectOptionArrayConvertor : JsonConverter<HassSelectorOption?[]?>
{
    public override HassSelectorOption?[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var converter = new JsonSelectOptionConverter();

        if (reader.TokenType == JsonTokenType.Null)
            return null;

        var list = new List<HassSelectorOption?>();

        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        reader.Read();

        while (reader.TokenType != JsonTokenType.EndArray)
        {
            list.Add(converter.Read(ref reader, typeof(HassSelectorOption), options));            
        }

        return list.ToArray();

    }

    public override void Write(Utf8JsonWriter writer, HassSelectorOption?[]? value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize<HassSelectorOption?[]?>(writer, value, options);
    }
}
