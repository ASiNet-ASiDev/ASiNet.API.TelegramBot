using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class LinkPreviewOptions
{
    /// <summary>
    /// Optional. True, if the link preview is disabled
    /// </summary>
    [JsonPropertyName("is_disabled")]
    public bool? IsDisabled { get; set; }
    /// <summary>
    /// Optional. URL to use for the link preview. If empty, then the first URL found in the message text will be used
    /// </summary>
    [JsonPropertyName("url")]
    public string? Uri { get; set; }
    /// <summary>
    /// Optional. True, if the media in the link preview is supposed to be shrunk; 
    /// ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
    /// </summary>
    [JsonPropertyName("prefer_small_media")]
    public bool? PreferSmallMedia { get; set; }
    /// <summary>
    /// Optional. True, if the media in the link preview is supposed to be enlarged; 
    /// ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
    /// </summary>
    [JsonPropertyName("prefer_large_media")]
    public bool? PreferLargeMedia { get; set; }
    /// <summary>
    /// Optional. True, if the link preview must be shown above the message text; otherwise, the link preview will be shown below the message text
    /// </summary>
    [JsonPropertyName("show_above_text")]
    public bool? ShowAboveText { get; set; }

}
