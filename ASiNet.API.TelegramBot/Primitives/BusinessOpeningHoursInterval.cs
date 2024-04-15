using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class BusinessOpeningHoursInterval
{
    /// <summary>
    /// The minute's sequence number in a week, starting on Monday, marking the start of the time interval during which the business is open; 0 - 7 * 24 * 60
    /// </summary>
    [JsonPropertyName("opening_minute")]
    public int OpeningMinute { get; set; }

    /// <summary>
    /// The minute's sequence number in a week, starting on Monday, marking the end of the time interval during which the business is open; 0 - 8 * 24 * 60
    /// </summary>
    [JsonPropertyName("closing_minute")]
    public int ClosingMinute { get; set; }


}
