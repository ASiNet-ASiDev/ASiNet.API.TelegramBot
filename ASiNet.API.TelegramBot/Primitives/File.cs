using System.Text.Json.Serialization;
using ASiNet.API.TelegramBot.Primitives.Base;

namespace ASiNet.API.TelegramBot.Primitives;

/// <summary>
/// This object represents a file ready to be downloaded.
/// </summary>
public class File : TelegramFileId
{
    /// <summary>
    /// Optional. File path.
    /// </summary>
    [JsonPropertyName("file_path")]
    public string? FilePath { get; set; }
}
