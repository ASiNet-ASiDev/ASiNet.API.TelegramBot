using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASiNet.API.TelegramBot.Primitives;
public class Message
{
    /// <summary>
    /// Unique message identifier inside the chat
    /// </summary>
    [JsonPropertyName("message_id")]
    public long MessageId { get; set; }


    public long? MessageThreadId { get; set; }

    public User? From { get; set; }

    public Chat? SenderChat { get; set; }

    public int? SenderBoostCount { get; set; }

    public User? SenderBusinessBot { get; set; }

    /// <summary>
    /// Always 0. The field can be used to differentiate regular and inaccessible messages.
    /// </summary>
    [JsonPropertyName("date")]
    public long Date { get; set; }

    public string? BusinessConnectionId { get; set; }

    /// <summary>
    /// Chat the message belonged to
    /// </summary>
    [JsonPropertyName("chat")]
    public Chat Chat { get; set; } = null!;

    public MessageOrigin? ForwardOrigin { get; set; }

    public bool? IsTopicMessage { get; set; }

    public bool? IsAutomaticForward {  get; set; }

    public Message? ReplyToMessage { get; set; }

    public ExternalReplyInfo? ExternalReply { get; set; }

    public TextQuote? Quote { get; set; }

    public Story? ReplyToStory { get; set; }

    public User? ViaBot { get; set; }

    public long? EditDate { get; set; }

    public bool? HasProtectedContent { get; set; }

    public bool? IsFromOffline { get; set; }

    public string? MediaGroupId { get; set; }

    public string? AuthorSignature { get; set; }

    public string? Text { get; set; }

    public MessageEntity[]? Entities { get; set; }

    public LinkPreviewOptions? LinkPreviewOptions { get; set; }

    public Animation? Animation { get; set; }

    public Audio? Audio { get; set; }

    public Document? Document { get; set; }

    public PhotoSize? Photo { get; set; }

    public Stiker? Stiker { get; set; }

    public Story? Story { get; set; }

    public Video? Video { get; set; }

    public VideoNote? VideoNote { get; set; }

    public Voice? Voice { get; set; }

    public string? Caption { get; set; }

    public MessageEntity[]? CaptionEntities { get; set; }

    public bool HasMediaSpoiler { get; set; }

    public Contact? Contact { get; set; }

    public Dice? Dice { get; set; }

    public Game? Game { get; set; }

    public Poll? Poll { get; set; }

    public Venue? Venue { get; set; }

    public Location? Location { get; set; }

    public User[]? NewChatMember {  get; set; }

    public string? NewChatTitle { get; set; }

    public PhotoSize[]? NewChatPhoto { get; set; }

    public bool? DeleteChatPhoto { get; set; }

    public bool? GroupChatCreated { get; set; }

    public bool? SupergroupChatCreated { get; set; }

    public bool? ChannelChatCreated { get; set; }

    public MessageAutoDeletedTimeChanget? MessageAutoDeletedTimeChanget { get; set; }

    public long? MigrateFromChatId { get; set; }

    public Message? PinnedMessage { get; set; }

    public Invoice? Invoice { get; set; }
    //TODO
}
