using ASiNet.API.TelegramBot.Enums;

namespace ASiNet.API.TelegramBot.Base;
public static class ChatTypeHelper
{

    public static ChatType GetChatType(string type) => type switch
    {
        "private" => ChatType.Private,
        "group" => ChatType.Group,
        "supergroup" => ChatType.Supergroup,
        "channel" => ChatType.Channel,
        _ => throw new NotSupportedException(type),
    };
}
