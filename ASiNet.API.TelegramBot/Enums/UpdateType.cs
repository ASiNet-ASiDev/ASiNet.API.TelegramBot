namespace ASiNet.API.TelegramBot.Enums;

[Flags]
public enum UpdateType
{
    /// <summary>
    /// EN:<br/>
    /// New incoming message of any kind - text, photo, sticker, etc.
    /// <para/>RU:<br/>
    /// Новое входящее сообщение любого типа - текст, фотография, наклейка и т.д.
    /// </summary>
    Message = 1 << 0,
    /// <summary>
    /// EN:<br/>
    /// New version of a message that is known to the bot and was edited.<br/>
    /// This update may at times be triggered by changes to message fields that are either unavailable or not actively used by your bot.
    /// <para/>RU:<br/>
    /// Новая версия сообщения, которое известно боту и было отредактировано. <br/>
    /// Это обновление иногда может быть вызвано изменениями в полях сообщения, которые либо недоступны, либо не используются вашим ботом активно.
    /// </summary>
    EditedMessage = 1 << 1,
    /// <summary>
    /// EN:<br/>
    /// New incoming channel post of any kind - text, photo, sticker, etc.
    /// <para/>RU:<br/>
    /// Новая входящая публикация на канале любого рода - текст, фотография, стикер и т.д.
    /// </summary>
    ChannelPost = 1 << 2,
    /// <summary>
    /// EN:<br/>
    /// New version of a channel post that is known to the bot and was edited. <br/>
    /// This update may at times be triggered by changes to message fields that are either unavailable or not actively used by your bot.
    /// <para/>RU:<br/>
    /// Новая версия публикации в канале, которая известна боту и была отредактирована. <br/> 
    /// Это обновление иногда может быть вызвано изменениями в полях сообщений, которые либо недоступны, либо не используются вашим ботом активно.
    /// </summary>
    EditedChannelPost = 1 << 3,
    /// <summary>
    /// EN:<br/>
    /// The bot was connected to or disconnected from a business account, or a user edited an existing connection with the bot
    /// <para/>RU:<br/>
    /// Бот был подключен к бизнес-аккаунту или отключен от него, или пользователь отредактировал существующее соединение с ботом
    /// </summary>
    BusinessConnection = 1 << 4,
    /// <summary>
    /// EN:<br/>
    /// New non-service message from a connected business account
    /// <para/>RU:<br/>
    /// Новое неслужебное сообщение от подключенного бизнес-аккаунта
    /// </summary>
    BusinessMessage = 1 << 5,
    /// <summary>
    /// EN:<br/>
    /// New version of a message from a connected business account
    /// <para/>RU:<br/>
    /// Новая версия сообщения из подключенного бизнес-аккаунта
    /// </summary>
    EditedBusinessMessage = 1 << 6,
    /// <summary>
    /// EN:<br/>
    /// Messages were deleted from a connected business account
    /// <para/>RU:<br/>
    /// Сообщения были удалены из подключенного бизнес-аккаунта
    /// </summary>
    DeletedBusinessMessage = 1 << 7,
    /// <summary>
    /// EN:<br/>
    /// A reaction to a message was changed by a user. <br/>
    /// The bot must be an administrator in the chat and must explicitly specify in the list of allowed_updates to receive these updates. <br/>
    /// The update isn't received for reactions set by bots.
    /// <para/>RU:<br/>
    /// Реакция на сообщение была изменена пользователем. <br/>
    /// Бот должен быть администратором в чате и должен явно указать в списке разрешенных обновлений, чтобы получать эти обновления. <br/>
    /// Обновление не будет получено для реакций, установленных ботами.
    /// </summary>
    MessageReaction = 1 << 8,
    /// <summary>
    /// EN:<br/>
    /// Reactions to a message with anonymous reactions were changed. <br/>
    /// The bot must be an administrator in the chat and must explicitly specify in the list of allowed_updates to receive these updates. <br/>
    /// The updates are grouped and can be sent with delay up to a few minutes
    /// <para/>RU:<br/>
    /// Реакции на сообщение с анонимными реакциями были изменены. <br/>
    /// Бот должен быть администратором в чате и должен явно указывать в списке разрешенных обновлений, чтобы получать эти обновления. <br/>
    /// Обновления сгруппированы и могут отправляться с задержкой до нескольких минут
    /// </summary>
    MessageReactionCount = 1 << 9,
    /// <summary>
    /// EN:<br/>
    /// New incoming <a href="https://core.telegram.org/bots/api#inline-mode">inline</a> query
    /// <para/>RU:<br/>
    /// Новый входящий <a href="https://core.telegram.org/bots/api#inline-mode">встроенный</a> запрос
    /// </summary>
    InlineQuery = 1 << 10,
    /// <summary>
    /// EN:<br/>
    /// The result of an <a href="https://core.telegram.org/bots/api#inline-mode">inline</a> query that was chosen by a user and sent to their chat partner. 
    /// Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.
    /// <para/>RU:<br/>
    /// Результат <a href="https://core.telegram.org/bots/api#inline-mode">встроенного</a> запроса, который был выбран пользователем и отправлен его партнеру по чату. 
    /// Пожалуйста, ознакомьтесь с нашей документацией по сбору отзывов для получения подробной информации о том, как включить эти обновления для вашего бота.
    /// </summary>
    ChosenInlineResult = 1 << 11,
    /// <summary>
    /// EN:<br/>
    /// New incoming callback query
    /// <para/>RU:<br/>
    /// Новый входящий запрос обратного вызова
    /// </summary>
    CallbackQuery = 1 << 12,
    /// <summary>
    /// EN:<br/>
    /// New incoming shipping query. Only for invoices with flexible price
    /// <para/>RU:<br/>
    /// Новый входящий запрос на доставку. Только для счетов-фактур с гибкой ценой
    /// </summary>
    ShippingQuery = 1 << 13,
    /// <summary>
    /// EN:<br/>
    /// New incoming pre-checkout query. Contains full information about checkout
    /// <para/>RU:<br/>
    /// Новый входящий запрос на предварительную регистрацию отъезда. Содержит полную информацию о регистрации отъезда
    /// </summary>
    PreCheckoutQuery = 1 << 14,
    /// <summary>
    /// EN:<br/>
    /// New poll state. Bots receive only updates about manually stopped polls and polls, which are sent by the bot
    /// <para/>RU:<br/>
    /// Новое состояние опроса. Боты получают только обновления об опросах, остановленных вручную, и опросах, которые отправляются ботом
    /// </summary>
    Poll = 1 << 15,
    /// <summary>
    /// EN:<br/>
    /// A user changed their answer in a non-anonymous poll. Bots receivenewvotes only in polls that were sent by the bot itself.
    /// <para/>RU:<br/>
    /// Пользователь изменил свой ответ в неанонимном опросе. Боты получают новые голоса только в опросах, которые были отправлены самим ботом.
    /// </summary>
    PollAnswer = 1 << 16,
    /// <summary>
    /// EN:<br/>
    /// The bot's chat member status was updated in a chat. <br/>
    /// For private chats, this update is received only when the bot is blocked or unblocked by the user.
    /// <para/>RU:<br/>
    /// Статус участника чата бота был обновлен в чате. <br/>
    /// Для приватных чатов это обновление появляется только тогда, когда пользователь блокирует или разблокирует бота.
    /// </summary>
    MyChatMember = 1 << 17,
    /// <summary>
    /// EN:<br/>
    /// A chat member's status was updated in a chat. <br/>
    /// The bot must be an administrator in the chat and must explicitly specify in the list of allowed_updates to receive these updates.
    /// <para/>RU:<br/>
    /// Статус участника чата был обновлен в чате. <br/>
    /// Бот должен быть администратором чата и должен явно указать в списке разрешенных обновлений, чтобы получать эти обновления.
    /// </summary>
    ChatMember = 1 << 18,
    /// <summary>
    /// EN:<br/>
    /// A request to join the chat has been sent. The bot must have the can_invite_users administrator right in the chat to receive these updates.
    /// <para/>RU:<br/>
    /// Был отправлен запрос на присоединение к чату. Для получения этих обновлений у бота должны быть права администратора can_invite_users в чате.
    /// </summary>
    ChatJoinRequest = 1 << 19,
    /// <summary>
    /// EN:<br/>
    /// A chat boost was added or changed. The bot must be an administrator in the chat to receive these updates.
    /// <para/>RU:<br/>
    /// Добавлена или изменена поддержка чата. Для получения этих обновлений бот должен быть администратором чата.
    /// </summary>
    ChatBoost = 1 << 20,
    /// <summary>
    /// EN:<br/>
    /// A boost was removed from a chat. The bot must be an administrator in the chat to receive these updates.
    /// <para/>RU:<br/>
    /// Бот был удален из чата. Для получения этих обновлений бот должен быть администратором в чате.
    /// </summary>
    RemovedChatBoost = 1 << 21,
}
