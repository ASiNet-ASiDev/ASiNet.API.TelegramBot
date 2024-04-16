using System.Text.Json.Serialization;
using ASiNet.API.TelegramBot.Primitives.Base;

namespace ASiNet.API.TelegramBot.Primitives;

public class VideoNote : TelegramFileId
{
    /// <summary>
    /// Video width and height (diameter of the video message) as defined by sender
    /// </summary>
    [JsonPropertyName("length")]
    public int Length { get; set; }
    /// <summary>
    /// Duration of the video in seconds as defined by sender
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
    /// <summary>
    /// Optional. Video thumbnail
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public PhotoSize? Tumbnail { get; set; }
}
