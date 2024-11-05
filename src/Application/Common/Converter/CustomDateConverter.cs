using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Application.Common.Converter;

public class CustomDateConverter : JsonConverter<DateTime>
{
    private static readonly CultureInfo Culture = CultureInfo.InvariantCulture;
    
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Attempt to parse the date in "dd-MMM-yy" format.
        var s = reader.GetString();
        if (DateTime.TryParseExact(s, "dd-MMM-yy", Culture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal, out DateTime date))
        {
            return date;
        }

        throw new JsonException("Invalid date format. Expected format is dd-MMM-yy.");
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("dd-MMM-yy"));
    }
}