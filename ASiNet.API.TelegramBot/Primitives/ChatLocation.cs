using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class ChatLocation
{
    /// <summary>
    /// The location to which the supergroup is connected. Can't be a live location.
    /// </summary>
    [JsonPropertyName("location")]
    public Location Location { get; set; } = null!;
    /// <summary>
    /// Location address; 1-64 characters, as defined by the chat owner
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; } = null!;
}
