using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Dice
{
    /// <summary>
    /// Emoji on which the dice throw animation is based
    /// </summary>
    [JsonPropertyName("emoji")]
    public string Emoji { get; set; } = null!;
    /// <summary>
    /// Value of the dice
    /// </summary>

    [JsonPropertyName("value")]
    public int Value { get; set; }
}
