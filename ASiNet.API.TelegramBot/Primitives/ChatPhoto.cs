using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
/// <summary>
/// EN<br/>
/// This object represents a chat photo.
/// <para/>RU<br/>
/// Этот объект представляет собой фотографию из чата.
/// </summary>
public class ChatPhoto
{
    /// <summary>
    /// EN<br/>
    /// File identifier of small (160x160) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.
    /// <para/>RU<br/>
    /// Идентификатор файла небольшой (160x160) фотографии для чата. 
    /// Этот идентификатор файла можно использовать только для загрузки фотографии и только до тех пор, пока фотография не будет изменена.
    /// </summary>
    [JsonPropertyName("small_file_id")]
    public string SmallFileId { get; set; } = null!;
    /// <summary>
    /// EN<br/>
    /// Unique file identifier of small (160x160) chat photo, which is supposed to be the same over time and for different bots. 
    /// Can't be used to download or reuse the file.
    /// <para/>RU<br/>
    /// Уникальный идентификатор файла небольшой (160x160) фотографии для чата, который должен оставаться неизменным с течением времени и для разных ботов. 
    /// Файл нельзя использовать для загрузки или повторного использования.
    /// </summary>
    [JsonPropertyName("small_file_unique_id")]
    public string SmallFileUniqueId { get; set; } = null!;
    /// <summary>
    /// EN<br/>
    /// File identifier of big (640x640) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.
    /// <para/>RU<br/>
    /// Идентификатор файла большой (640x640) фотографии для чата. 
    /// Этот идентификатор файла можно использовать только для загрузки фотографии и только до тех пор, пока фотография не будет изменена.
    /// </summary>
    [JsonPropertyName("big_file_id")]
    public string BigFileId { get; set; } = null!;
    /// <summary>
    /// EN<br/>
    /// Unique file identifier of big (640x640) chat photo, which is supposed to be the same over time and for different bots. 
    /// Can't be used to download or reuse the file.
    /// <para/>RU<br/>
    /// 
    /// </summary>Уникальный идентификатор файла большой (640x640) фотографии для чата, который должен оставаться неизменным с течением времени и для разных ботов. 
    /// Файл нельзя использовать для загрузки или повторного использования.
    [JsonPropertyName("big_file_unique_id")]
    public string BigFileUniqueId { get; set; } = null!;

}
