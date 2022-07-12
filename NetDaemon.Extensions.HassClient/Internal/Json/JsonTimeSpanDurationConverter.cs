using System.Text.Json;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Json;

/// <summary>
/// Reads/Writes TimeSpan as simple time spec or as complex object
/// </summary>
internal class JsonTimeSpanDurationConverter : JsonConverter<TimeSpan>
{
    public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number)
            return TimeSpan.FromSeconds(reader.GetDouble());

        if (reader.TokenType == JsonTokenType.StartObject)
        {
            TimeSpan result = TimeSpan.Zero;
            reader.Read();
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                switch (reader.GetString())
                {
                    case "days":
                        reader.Read();
                        result.Add(TimeSpan.FromDays(reader.GetDouble()));
                        break;
                    case "hours":
                        reader.Read();
                        result.Add(TimeSpan.FromHours(reader.GetDouble()));
                        break;
                    case "minutes":
                        reader.Read();
                        result.Add(TimeSpan.FromMinutes(reader.GetDouble()));
                        break;
                    case "seconds":
                        reader.Read();
                        result.Add(TimeSpan.FromSeconds(reader.GetDouble()));
                        break;
                    case "milliseconds":
                        reader.Read();
                        result.Add(TimeSpan.FromMilliseconds(reader.GetDouble()));
                        break;
                    default:
                        throw new JsonException("Unexpected timespan component");
                }
                reader.Read();
            }
            return result;
        }

        return TimeSpan.Parse(reader.GetString()!);


    }

    public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
    {

        var duration = value.Duration();

        if (duration.TotalDays < 1 && duration.Milliseconds == 0)
            writer.WriteStringValue(duration.ToString("hh:mm:ss"));
        else
        {
            writer.WriteStartObject();
            if (duration.Days > 0)
                writer.WriteNumber("days", duration.Days);
            if (duration.Hours > 0)
                writer.WriteNumber("hours", duration.Hours);
            if (duration.Minutes > 0)
                writer.WriteNumber("minutes", duration.Minutes);
            if (duration.Seconds > 0)
                writer.WriteNumber("seconds", duration.Seconds);
            if (duration.Milliseconds > 0)
                writer.WriteNumber("milliseconds", duration.Milliseconds);
            writer.WriteEndObject();
        }
    }
}
