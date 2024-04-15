using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class CallbackQuery
{
    /// <summary>
    /// Unique identifier for this query
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    /// <summary>
    /// Sender
    /// </summary>
    [JsonPropertyName("from")]
    public User From { get; set; }
    /// <summary>
    /// Optional. Message sent by the bot with the callback button that originated the query
    /// </summary>
    [JsonPropertyName("message")]
    public Message? Message { get; set; }
    /// <summary>
    /// Optional. Identifier of the message sent via the bot in inline mode, that originated the query.
    /// </summary>
    [JsonPropertyName("inline_message_id")]
    public string? InlineMessageId { get; set; }
    /// <summary>
    /// Global identifier, uniquely corresponding to the chat to which the message with the callback button was sent. Useful for high scores in games.
    /// </summary>
    [JsonPropertyName("chat_instance")]
    public string? ChatInstance { get; set; }
    /// <summary>
    /// Optional. Data associated with the callback button. Be aware that the message originated the query can contain no callback buttons with this data.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }
    /// <summary>
    /// Optional. Short name of a Game to be returned, serves as the unique identifier for the game
    /// </summary>
    [JsonPropertyName("game_short_name")]
    public string? GameShortName { get; set; }

}
