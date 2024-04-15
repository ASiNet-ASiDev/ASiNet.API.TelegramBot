using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASiNet.API.TelegramBot.Primitives;

/// <summary>
/// EN:<br/>
/// This object represents a Telegram user or bot.
/// <para/>
/// RU:<br/>
/// Этот объект представляет пользователя или бота Telegram.
/// </summary>
public class User
{
    /// <summary>
    /// EN:<br/>
    /// Unique identifier for this user or bot.
    /// <para/>
    /// RU:<br/>
    /// Уникальный идентификатор для этого пользователя или бота.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }
    /// <summary>
    /// EN:<br/>
    /// True if this user is a bot
    /// <para/>
    /// RU:<br/>
    /// Верно, если этот пользователь является ботом
    /// </summary>
    [JsonPropertyName ("is_bot")]
    public bool IsBot { get; set; }
    /// <summary>
    /// EN:<br/>
    /// User's or bot's first name
    /// <para/>RU:<br/>
    /// Имя пользователя или бота
    /// </summary>
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; } = null!;
    /// <summary>
    /// EN:<br/>
    /// Optional. User's or bot's last name
    /// <para/>RU:<br/>
    /// Необязательный. Фамилия пользователя или бота
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }
    /// <summary>
    /// EN:<br/>
    /// Optional. User's or bot's username
    /// <para/>RU:<br/>
    /// Необязательный. Имя пользователя или бота
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
    /// <summary>
    /// EN:<br/>
    /// Optional. <a href="https://en.wikipedia.org/wiki/IETF_language_tag">IETF language tag</a> of the user's language
    /// <para/>RU:<br/>
    /// Необязательный. <a href="https://en.wikipedia.org/wiki/IETF_language_tag">Языковой тег IETF</a> для языка пользователя
    /// </summary>
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
    /// <summary>
    /// EN:<br/>
    /// Optional. True, if this user is a Telegram Premium user
    /// <para/>RU:<br/>
    /// Optional. True, if this user is a Telegram Premium user
    /// </summary>
    [JsonPropertyName("is_premium")]
    public bool IsPremium { get; set; }
    /// <summary>
    /// EN:<br/>
    /// Optional. True, if this user added the bot to the attachment menu
    /// <para/>RU:<br/>
    /// Необязательный. Верно, если этот пользователь добавил бота в меню вложений
    /// </summary>
    [JsonPropertyName("added_to_attachment_menu")]
    public bool AddedToAttachmentMenu { get; set; }
    /// <summary>
    /// EN:<br/>
    /// Optional. True, if the bot can be invited to groups. Returned only in get Me.
    /// <para/>RU:<br/>
    /// Необязательный. Это верно, если бота можно приглашать в группы. Возвращается только в get Me.
    /// </summary>
    [JsonPropertyName("can_join_groups")]
    public bool CanJoinGroups { get; set; }
    /// <summary>
    /// EN:<br/>
    /// Optional. True, if <a href="https://core.telegram.org/bots/features#privacy-mode">privacy mode</a> is disabled for the bot. Returned only in getMe.
    /// <para/>RU:<br/>
    ///  Необязательный. Это верно, если у бота отключен <a href="https://core.telegram.org/bots/features#privacy-mode">режим конфиденциальности.</a> Возвращается только в get Me.
    /// </summary>
    [JsonPropertyName("can_read_all_group_messages")]
    public bool CanReadAllGroupMessages { get; set; }
    /// <summary>
    /// EN:<br/>
    /// Optional. True, if the bot supports inline queries. Returned only in getMe.
    /// <para/>RU:<br/>
    /// Необязательный. Верно, если бот поддерживает встроенные запросы. Возвращается только в get Me.
    /// </summary>
    [JsonPropertyName("supports_inline_queries")]
    public bool SupportInlineQueries { get; set; }
    /// <summary>
    /// EN:<br/>
    /// Optional. True, if the bot can be connected to a Telegram Business account to receive its messages. Returned only in getMe.
    /// <para/>RU:<br/>
    /// Необязательный. Это верно, если бот может быть подключен к бизнес-аккаунту Telegram для получения его сообщений. Возвращается только в get Me.
    /// </summary>
    [JsonPropertyName("can_connect_to_business")]
    public bool CanConnectToBusiness { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine($"Id: {Id}")
            .AppendLine($"IsBot: {IsBot}")
            .AppendLine($"FirstName: {FirstName}")
            .AppendLine($"LastName: {LastName}")
            .AppendLine($"Username: {Username}")
            .AppendLine($"LanguageCode: {LanguageCode}")
            .AppendLine($"IsPremium: {IsPremium}")
            .AppendLine($"AddedToAttachmentMenu: {AddedToAttachmentMenu}")
            .AppendLine($"CanJoinGroups: {CanJoinGroups}")
            .AppendLine($"CanReadAllGroupMessages: {CanReadAllGroupMessages}")
            .AppendLine($"SupportInlineQueries: {SupportInlineQueries}")
            .AppendLine($"CanConnectToBusiness: {CanConnectToBusiness}")
            .ToString();
    }
}
