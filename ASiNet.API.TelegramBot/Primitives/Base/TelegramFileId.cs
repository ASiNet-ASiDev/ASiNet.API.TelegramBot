using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives.Base;

/// <summary>
/// Contains Properties:
/// <list type="bullet">
/// <item><see cref="TelegramFileId.FileId"/></item>
/// <item><see cref="TelegramFileId.FileUniqueId"/></item>
/// <item><see cref="TelegramFileId.FileSize"/></item>
/// </list>
/// </summary>
public abstract class TelegramFileId
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
    /// Optional. File size in bytes. It can be bigger than 2^31 and some programming languages may have difficulty/silent defects in interpreting it. 
    /// But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this value.
    /// </summary>
    [JsonPropertyName("file_size")]
    public int? FileSize { get; set; }
}
