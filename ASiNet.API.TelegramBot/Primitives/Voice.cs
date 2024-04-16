using System.Text.Json.Serialization;
using ASiNet.API.TelegramBot.Primitives.Base;

namespace ASiNet.API.TelegramBot.Primitives;
public class Voice : TelegramFileId
{
    /// <summary>
    /// Duration of the audio in seconds as defined by sender
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
    /// <summary>
    /// Optional. MIME type of the file as defined by sender
    /// </summary>
    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; }
}
