using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class BusinessIntro
{
    /// <summary>
    /// Optional. Title text of the business intro
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// Optional. Message text of the business intro
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    /// <summary>
    /// Optional. Sticker of the business intro
    /// </summary>
    [JsonPropertyName("sticker")]
    public Stiker? Stiker { get; set; }

}
