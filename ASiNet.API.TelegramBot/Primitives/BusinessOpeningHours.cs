using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class BusinessOpeningHours
{
    /// <summary>
    /// Unique name of the time zone for which the opening hours are defined
    /// </summary>
    [JsonPropertyName("time_zone_name")]
    public string TimeZoneName { get; set; } = null!;
    /// <summary>
    /// List of time intervals describing business opening hours
    /// </summary>
    [JsonPropertyName("opening_hours")]
    public BusinessOpeningHoursInterval[] OpeningHours { get; set; } = null!;

}
