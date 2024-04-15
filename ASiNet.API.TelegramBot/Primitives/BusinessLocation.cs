using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class BusinessLocation
{
    /// <summary>
    /// Address of the business
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; } = null!;
    /// <summary>
    /// Optional. Location of the business
    /// </summary>
    [JsonPropertyName("location")]
    public Location? Location { get; set; }
}
