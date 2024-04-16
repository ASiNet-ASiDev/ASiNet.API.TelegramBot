using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Audio : Document
{
    /// <summary>
    /// Duration of the audio in seconds as defined by sender
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
    /// <summary>
    /// Optional. Performer of the audio as defined by sender or by audio tags
    /// </summary>
    [JsonPropertyName("performer")]
    public string? Perfirmer { get; set; }
    /// <summary>
    /// Optional. Title of the audio as defined by sender or by audio tags
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
