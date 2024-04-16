using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Story
{
    /// <summary>
    /// Chat that posted the story
    /// </summary>
    [JsonPropertyName("chat")]
    public Chat Chat { get; set; } = null!;
    /// <summary>
    /// Unique identifier for the story in the chat
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
