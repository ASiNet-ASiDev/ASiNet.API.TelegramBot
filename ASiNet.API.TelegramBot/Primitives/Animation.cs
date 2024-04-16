using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Animation : Document
{
    /// <summary>
    /// Video width as defined by sender
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }
    /// <summary>
    /// Video height as defined by sender
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }
    /// <summary>
    /// Duration of the video in seconds as defined by sender
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}
