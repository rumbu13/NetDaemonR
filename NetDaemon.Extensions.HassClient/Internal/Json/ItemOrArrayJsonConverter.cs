using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Json;



#pragma warning disable CS8604 // T can be nullable
/// <summary>
/// Allows reading json fields which are writen as "value" when there is
/// a sigle element or as ["value1", "value2", ...] when there are multiple elements
/// </summary>
/// <typeparam name="A">Array or any collection type</typeparam>
/// <typeparam name="T">Item of array/collection</typeparam>
internal class ItemOrArrayJsonConverter<A, T> : JsonConverter<A> where A : class, ICollection<T>, new()
{
    public override A? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)            
            return null;
        if (reader.TokenType == JsonTokenType.StartArray)
        {
            var array = new A();
            reader.Read();
            while (reader.TokenType != JsonTokenType.EndArray)
            {

                array.Add(JsonSerializer.Deserialize<T>(ref reader, options));

                reader.Read();
            }
            return array;
        }
        return new A() 
        { 
            JsonSerializer.Deserialize<T>(ref reader, options) 
        };
    }
#pragma warning restore CS8604 // T can be nullable


    public override void Write(Utf8JsonWriter writer, A value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Never)
                writer.WriteNullValue();
        }
        else if (value.Count == 1)
            JsonSerializer.Serialize(writer, value.First(), options);
        else
        {
            writer.WriteStartArray();
            foreach (var item in value)
                JsonSerializer.Serialize(writer, item, options);
            writer.WriteEndArray();
        }
    }
}
