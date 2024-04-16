using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Poll
{
    /// <summary>
    /// Unique poll identifier
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    /// <summary>
    /// Poll question, 1-300 characters
    /// </summary>
    [JsonPropertyName("question")]
    public string Question { get; set; } = null!;
    /// <summary>
    /// List of poll options
    /// </summary>
    [JsonPropertyName("options")]
    public PollOption[] Options { get; set; } = null!;
    /// <summary>
    /// Total number of users that voted in the poll
    /// </summary>
    [JsonPropertyName("total_voter_count")]
    public int TotalVoterCount { get; set; }
    /// <summary>
    /// True, if the poll is closed
    /// </summary>
    [JsonPropertyName("is_closed")]
    public bool IsClosed { get; set; }
    /// <summary>
    /// True, if the poll is anonymous
    /// </summary>
    [JsonPropertyName("is_anonymous")]
    public bool IsAnonymous { get; set; }
    /// <summary>
    /// Poll type, currently can be “regular” or “quiz”
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
    /// <summary>
    /// True, if the poll allows multiple answers
    /// </summary>
    [JsonPropertyName("allows_multiple_answers")]
    public bool AllowMultipleAnswers { get; set; }
    /// <summary>
    /// Optional. 0-based identifier of the correct answer option. 
    /// only for polls in the quiz mode, which are closed, or was sent (not forwarded) by the bot or to the private chat with the bot.
    /// </summary>
    [JsonPropertyName("correct_option_id")]
    public int? CorrectOptionId { get; set; }
    /// <summary>
    /// Optional. Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters
    /// </summary>
    [JsonPropertyName("explanation")]
    public string? Explanation { get; set; }
    /// <summary>
    /// Optional. Special entities like usernames, URLs, bot commands, etc. that appear in the explanation
    /// </summary>
    [JsonPropertyName("explanation_entities")]
    public MessageEntity[]? ExplanationEntities { get; set; }
    /// <summary>
    /// Optional. Amount of time in seconds the poll will be active after creation
    /// </summary>
    [JsonPropertyName("open_period")]
    public long? OpenPeriod { get; set; }
    /// <summary>
    /// Optional. Point in time (Unix timestamp) when the poll will be automatically closed
    /// </summary>
    [JsonPropertyName("close_date")]
    public long? CloseDate { get; set; }
}
