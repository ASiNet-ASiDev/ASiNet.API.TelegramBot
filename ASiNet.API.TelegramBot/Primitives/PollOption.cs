using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class PollOption
{
    /// <summary>
    /// Option text, 1-100 characters
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = null!;
    /// <summary>
    /// Number of users that voted for this option
    /// </summary>
    [JsonPropertyName("voter_count")]
    public int VoterCount { get; set; }
}
