using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Game
{
    /// <summary>
    /// Title of the game
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;
    /// <summary>
    /// Description of the game
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;
    /// <summary>
    /// Photo that will be displayed in the game message in chats.
    /// </summary>
    [JsonPropertyName("photo")]
    public PhotoSize[] Photo { get; set; } = null!;
    /// <summary>
    /// Optional. Brief description of the game or high scores included in the game message.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
    /// <summary>
    /// Optional. Special entities that appear in text, such as usernames, URLs, bot commands, etc.
    /// </summary>
    [JsonPropertyName("text_entities")]
    public MessageEntity[]? TextEntities { get; set; }
    /// <summary>
    /// Optional. Animation that will be displayed in the game message in chats. Upload via BotFather
    /// </summary>
    [JsonPropertyName("animation")]
    public Animation? Animation { get; set; }
}
