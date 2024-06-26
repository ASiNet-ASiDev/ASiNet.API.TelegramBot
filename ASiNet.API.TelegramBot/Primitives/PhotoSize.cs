﻿using System.Text.Json.Serialization;
using ASiNet.API.TelegramBot.Primitives.Base;

namespace ASiNet.API.TelegramBot.Primitives;
/// <summary>
/// This object represents one size of a photo or a file / sticker thumbnail.
/// </summary>
public class PhotoSize : TelegramFileId
{
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
}
