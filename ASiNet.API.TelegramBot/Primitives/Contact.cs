using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Contact
{
    /// <summary>
    /// Contact's phone number
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; } = null!;
    /// <summary>
    /// Contact's first name
    /// </summary>
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; } = null!;
    /// <summary>
    /// Optional. Contact's last name
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }
    /// <summary>
    /// Optional. Contact's user identifier in Telegram.
    /// </summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }
    /// <summary>
    /// Optional. Additional data about the contact in the form of a vCard
    /// </summary>
    [JsonPropertyName("vcard")]
    public string? VCard { get; set; }
}
