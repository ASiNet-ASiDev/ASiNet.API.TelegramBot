using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class MessageAutoDeletedTimeChanget
{
    /// <summary>
    /// New auto-delete time for messages in the chat; in seconds
    /// </summary>
    [JsonPropertyName("message_auto_delete_time")]
    public long MessageAutoDeleteTime { get; set; }


}
