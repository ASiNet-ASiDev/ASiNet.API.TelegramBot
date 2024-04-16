using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class MessageOrigin
{
    /// <summary>
    /// Type of the message origin.<br/>
    /// <list type="bullet">
    ///     <item> user </item>
    ///     <item> hidden_user </item>
    ///     <item> chat </item>
    ///     <item> channel </item> 
    ///     <item> channel </item> 
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
    /// <summary>
    /// Date the message was sent originally in Unix time
    /// </summary>
    [JsonPropertyName("date")]
    public long Date { get; set; }
    /// <summary>
    /// User that sent the message originally
    /// </summary>
    [JsonPropertyName("sender_user")]
    public User? SenderUser { get; set; }
    /// <summary>
    /// Name of the user that sent the message originally
    /// </summary>
    [JsonPropertyName("sender_user_name")]
    public string? SenderUserName { get; set; }
    /// <summary>
    /// Chat that sent the message originally
    /// </summary>
    [JsonPropertyName("sender_chat")]
    public Chat? SenderChat { get; set; }
    /// <summary>
    /// Optional. <br/>
    /// For messages originally sent by an anonymous chat administrator, original message author signature <br/>
    /// OR <br/>
    /// Signature of the original post author
    /// </summary>
    [JsonPropertyName("author_signature")]
    public string? AuthorSignature { get; set; }
    /// <summary>
    /// Channel chat to which the message was originally sent
    /// </summary>
    [JsonPropertyName("chat")]
    public Chat? SenderCannel { get; set; }
    /// <summary>
    /// Unique message identifier inside the chat
    /// </summary>
    [JsonPropertyName("message_id")]
    public long MessageId { get; set; }

}
