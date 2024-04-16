using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASiNet.API.TelegramBot.Primitives;
public class TextQuote
{
    /// <summary>
    /// Text of the quoted part of a message that is replied to by the given message
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = null!;
    /// <summary>
    /// Optional. Special entities that appear in the quote. Currently, only bold, italic, underline, strikethrough, spoiler, and custom_emoji entities are kept in quotes.
    /// </summary>
    [JsonPropertyName("entities")]
    public MessageEntity[]? Entities { get; set; }
    /// <summary>
    /// Approximate quote position in the original message in UTF-16 code units as specified by the sender
    /// </summary>
    [JsonPropertyName("position")]
    public int Position { get; set; }
    /// <summary>
    /// Optional. True, if the quote was chosen manually by the message sender. Otherwise, the quote was added automatically by the server.
    /// </summary>
    [JsonPropertyName("is_manual")]
    public bool? IsManual { get; set; }

}
