using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
/// <summary>
/// This object represents one size of a photo or a file / sticker thumbnail.
/// </summary>
public class PhotoSize
{
    /// <summary>
    /// Identifier for this file, which can be used to download or reuse the file
    /// </summary>
    [JsonPropertyName("file_id")]
    public string FileId { get; set; } = null!;
    /// <summary>
    /// Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
    /// </summary>
    [JsonPropertyName("file_unique_id")]
    public string FileUniqueId { get; set; } = null!;
    /// <summary>
    /// Photo width
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }
    /// <summary>
    /// Photo height
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }
    /// <summary>
    /// Optional. File size in bytes
    /// </summary>
    [JsonPropertyName("file_size")]
    public int? FileSize { get; set; }
}
