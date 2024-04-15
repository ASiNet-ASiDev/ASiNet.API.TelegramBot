using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASiNet.API.TelegramBot.Primitives;
public class Message
{
    /// <summary>
    /// Chat the message belonged to
    /// </summary>
    [JsonPropertyName("chat")]
    public Chat Chat { get; set; } = null!;
    /// <summary>
    /// Unique message identifier inside the chat
    /// </summary>
    [JsonPropertyName("message_id")]
    public long MessageId { get; set; }
    /// <summary>
    /// Always 0. The field can be used to differentiate regular and inaccessible messages.
    /// </summary>
    [JsonPropertyName("date")]
    public long Date { get; set; }
}
