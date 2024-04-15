using System.Text.Json.Serialization;
using ASiNet.API.TelegramBot.Base;
using ASiNet.API.TelegramBot.Enums;

namespace ASiNet.API.TelegramBot.Primitives;
public class Chat
{
    /// <summary>
    /// Unique identifier for this chat.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }
    /// <summary>
    /// Type of chat, can be either “private”, “group”, “supergroup” or “channel”
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
    /// <summary>
    /// Optional. Title, for supergroups, channels and group chats
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// Optional. Username, for private chats, supergroups and channels if available
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
    /// <summary>
    /// Optional. First name of the other party in a private chat
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }
    /// <summary>
    /// Optional. Last name of the other party in a private chat
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }
    /// <summary>
    /// Optional. True, if the supergroup chat is a forum (has topics enabled)
    /// </summary>
    [JsonPropertyName("is_forum")]
    public bool? IsForum { get; set; }
    /// <summary>
    /// Optional. Chat photo. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("photo")]
    public ChatPhoto? Photo { get; set; }
    /// <summary>
    /// Optional. If non-empty, the list of all active chat usernames; for private chats, supergroups and channels. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("active_usernames")]
    public string[]? ActiveUsernames { get; set; }
    /// <summary>
    /// Optional. For private chats, the date of birth of the user. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("birthdate")]
    public Brithdate? Brithdate { get; set; }
    /// <summary>
    /// Optional. For private chats with business accounts, the intro of the business. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("business_intro")]
    public BusinessIntro? BusinessIntro { get; set; }
    /// <summary>
    /// Optional. For private chats with business accounts, the location of the business. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("business_location")]
    public BusinessLocation? BusinessLocation { get; set; }
    /// <summary>
    /// Optional. For private chats with business accounts, the opening hours of the business. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("business_opening_hours")]
    public BusinessOpeningHours? BusinessOpeningHours { get; set; }
    /// <summary>
    /// Optional. For private chats, the personal channel of the user. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("personal_chat")]
    public Chat? PersonalChat { get; set; }
    /// <summary>
    /// Optional. List of available reactions allowed in the chat. If omitted, then all emoji reactions are allowed. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("available_reactions")]
    public ReactionType[]? AvalibleReactions { get; set; }
    /// <summary>
    /// Optional. Identifier of the accent color for the chat name and backgrounds of the chat photo, reply header, and link preview. 
    /// See accent colors for more details. 
    /// Returned only in getChat. Always returned in getChat.
    /// </summary>
    [JsonPropertyName("accent_color_id")]
    public int? AccentColorId { get; set; }
    /// <summary>
    /// Optional. Custom emoji identifier of emoji chosen by the chat for the reply header and link preview background. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("background_custom_emoji_id")]
    public string? BacgroundCustomEmojiId { get; set; }
    /// <summary>
    /// Optional. Identifier of the accent color for the chat's profile background. See profile accent colors for more details. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("profile_accent_color_id")]
    public int? ProfileAccentColorId { get; set; }
    /// <summary>
    /// Optional. Custom emoji identifier of the emoji chosen by the chat for its profile background. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("profile_background_custom_emoji_id")]
    public string? ProfileBacgroundCustomEmojiId { get; set; }
    /// <summary>
    /// Optional. Custom emoji identifier of the emoji status of the chat or the other party in a private chat. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("emoji_status_custom_emoji_id")]
    public string? EmojiStatusCustimEmojiId { get; set; }
    /// <summary>
    /// Optional. Expiration date of the emoji status of the chat or the other party in a private chat, in Unix time, if any. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("emoji_status_expiration_date")]
    public int? EmojiStatusExpirationDate { get; set; }
    /// <summary>
    /// Optional. Bio of the other party in a private chat. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("bio")]
    public string? Bio { get; set; }
    /// <summary>
    /// Optional. True, if privacy settings of the other party in the private chat allows to use tg://user?id='user_id' links only in chats with the user. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("has_private_forwards")]
    public bool? HasPrivateForwards { get; set; }
    /// <summary>
    /// Optional. True, if the privacy settings of the other party restrict sending voice and video note messages in the private chat. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("has_restricted_voice_and_video_messages")]
    public bool? HasRestrictedVoiceAndVideoMessage { get; set; }
    /// <summary>
    /// Optional. True, if users need to join the supergroup before they can send messages. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("join_to_send_messages")]
    public bool? JoinToSendMessage { get; set; }
    /// <summary>
    /// Optional. True, if all users directly joining the supergroup need to be approved by supergroup administrators. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("join_by_request")]
    public bool? JoinByRequest { get; set; }
    /// <summary>
    /// Optional. Description, for groups, supergroups and channel chats. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    /// <summary>
    /// Optional. Primary invite link, for groups, supergroups and channel chats. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("invite_link")]
    public string? InviteLink { get; set; }
    /// <summary>
    /// Optional. The most recent pinned message (by sending date). Returned only in getChat.
    /// </summary>
    [JsonPropertyName("pinned_message")]
    public Message? PinnedMessage { get; set; }
    /// <summary>
    /// Optional. Default chat member permissions, for groups and supergroups. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("permissions")]
    public ChatPermissions? Permissions { get; set; }
    /// <summary>
    /// Optional. For supergroups, the minimum allowed delay between consecutive messages sent by each unprivileged user; in seconds. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("slow_mode_delay")]
    public int? SlowModeDelay { get; set; }
    /// <summary>
    /// Optional. For supergroups, the minimum number of boosts that a non-administrator user needs to add in order to ignore slow mode and chat permissions. 
    /// Returned only in getChat.
    /// </summary>
    [JsonPropertyName("unrestrict_boost_count")]
    public int? UnrestrictBoostCount { get; set; }
    /// <summary>
    /// Optional. The time after which all messages sent to the chat will be automatically deleted; in seconds. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("message_auto_delete_time")]
    public int? MessageAutoDeleteTime { get; set; }
    /// <summary>
    /// Optional. True, if aggressive anti-spam checks are enabled in the supergroup. 
    /// The field is only available to chat administrators. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("has_aggressive_anti_spam_enabled")]
    public bool? HasAggresiveAntiSpamEnabled { get; set; }
    /// <summary>
    /// Optional. True, if non-administrators can only get the list of bots and administrators in the chat. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("has_hidden_members")]
    public bool? HasHiddenMembers { get; set; }
    /// <summary>
    /// Optional. True, if messages from the chat can't be forwarded to other chats. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("has_protected_content")]
    public bool? HasProtectedContent { get; set; }
    /// <summary>
    /// Optional. True, if new chat members will have access to old messages; available only to chat administrators. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("has_visible_history")]
    public bool? HasVisibleHistory { get; set; }
    /// <summary>
    /// Optional. For supergroups, name of group sticker set. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("sticker_set_name")]
    public string? StickerSetName { get; set; }
    /// <summary>
    /// Optional. True, if the bot can change the group sticker set. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("can_set_sticker_set")]
    public bool? CanSetStickerSet { get; set; }
    /// <summary>
    /// Optional. For supergroups, the name of the group's custom emoji sticker set. 
    /// Custom emoji from this set can be used by all users and bots in the group. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("custom_emoji_sticker_set_name")]
    public string? CustomEmojiStickerSetName { get; set; }
    /// <summary>
    /// Optional. Unique identifier for the linked chat, i.e. the discussion group identifier for a channel and vice versa; for supergroups and channel chats.
    /// </summary>
    [JsonPropertyName("linked_chat_id")]
    public long? LinkedChatId { get; set; }
    /// <summary>
    /// Optional. For supergroups, the location to which the supergroup is connected. Returned only in getChat.
    /// </summary>
    [JsonPropertyName("location")]
    public ChatLocation? Location { get; set; }

    [JsonIgnore]
    public ChatType ChatType => ChatTypeHelper.GetChatType(Type);
}
