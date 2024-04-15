using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class ReactionType
{
    /// <summary>
    /// Type of the reaction, always “emoji” OR Type of the reaction, always “custom_emoji”
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
    /// <summary>
    /// Reaction emoji.
    /// </summary>
    [JsonPropertyName("emoji")]
    public string? Emoji { get; set; }
    /// <summary>
    /// Custom emoji identifier
    /// </summary>
    [JsonPropertyName("custom_emoji_id")]
    public string? CustomEmojiId { get; set; }
}
