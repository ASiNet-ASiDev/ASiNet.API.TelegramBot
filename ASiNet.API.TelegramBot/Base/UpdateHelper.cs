using System.Text.Json;
using ASiNet.API.TelegramBot.Enums;

namespace ASiNet.API.TelegramBot.Base;
internal static class UpdateHelper
{
    public static string GetAllowUpdatesString(UpdateType updateType)
    {
        var updates = new List<string>();

        if (updateType.HasFlag(UpdateType.Message))
            updates.Add("message");
        if (updateType.HasFlag(UpdateType.EditedMessage))
            updates.Add("edited_message");
        if (updateType.HasFlag(UpdateType.ChannelPost))
            updates.Add("channel_post");
        if (updateType.HasFlag(UpdateType.EditedChannelPost))
            updates.Add("edited_channel_post");
        if (updateType.HasFlag(UpdateType.BusinessConnection))
            updates.Add("business_connection");
        if (updateType.HasFlag(UpdateType.BusinessMessage))
            updates.Add("business_message");
        if (updateType.HasFlag(UpdateType.EditedBusinessMessage))
            updates.Add("edited_business_message");
        if (updateType.HasFlag(UpdateType.DeletedBusinessMessage))
            updates.Add("deleted_business_messages");
        if (updateType.HasFlag(UpdateType.MessageReaction))
            updates.Add("message_reaction");
        if (updateType.HasFlag(UpdateType.MessageReactionCount))
            updates.Add("message_reaction_count");
        if (updateType.HasFlag(UpdateType.InlineQuery))
            updates.Add("inline_query");
        if (updateType.HasFlag(UpdateType.ChosenInlineResult))
            updates.Add("chosen_inline_result");
        if (updateType.HasFlag(UpdateType.CallbackQuery))
            updates.Add("callback_query");
        if (updateType.HasFlag(UpdateType.ShippingQuery))
            updates.Add("shipping_query");
        if (updateType.HasFlag(UpdateType.PreCheckoutQuery))
            updates.Add("pre_checkout_query");
        if (updateType.HasFlag(UpdateType.Poll))
            updates.Add("poll");
        if (updateType.HasFlag(UpdateType.PollAnswer))
            updates.Add("poll_answer");
        if (updateType.HasFlag(UpdateType.MyChatMember))
            updates.Add("my_chat_member");
        if (updateType.HasFlag(UpdateType.ChatMember))
            updates.Add("chat_member");
        if (updateType.HasFlag(UpdateType.ChatJoinRequest))
            updates.Add("chat_join_request");
        if (updateType.HasFlag(UpdateType.ChatBoost))
            updates.Add("chat_boost");
        if (updateType.HasFlag(UpdateType.RemovedChatBoost))
            updates.Add("removed_chat_boost");

        return JsonSerializer.Serialize(updates);
    }
}
