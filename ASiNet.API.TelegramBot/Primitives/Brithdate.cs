using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;

public class Brithdate
{
    /// <summary>
    /// Day of the user's birth; 1-31
    /// </summary>
    [JsonPropertyName("day")]
    public int Day { get; set; }
    /// <summary>
    /// Month of the user's birth; 1-12
    /// </summary>
    [JsonPropertyName("month")]
    public int Month { get; set; }
    /// <summary>
    /// Optional. Year of the user's birth
    /// </summary>
    [JsonPropertyName("year")]
    public int Year { get; set; }

    [JsonIgnore]
    public DateTime Date => new DateTime(Year, Month, Day);
}
