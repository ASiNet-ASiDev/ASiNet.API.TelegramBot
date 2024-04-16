using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Document
{
    /// <summary>
    /// Optional. Original filename as defined by sender
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }
    /// <summary>
    /// Optional. MIME type of the file as defined by sender
    /// </summary>
    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; }

    /// <summary>
    /// Optional. Thumbnail as defined by sender
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public PhotoSize? Thumbnail { get; set; }
}
