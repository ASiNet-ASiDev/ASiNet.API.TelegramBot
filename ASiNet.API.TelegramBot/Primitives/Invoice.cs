using System.Text.Json.Serialization;

namespace ASiNet.API.TelegramBot.Primitives;
public class Invoice
{
    /// <summary>
    /// Product name
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;
    /// <summary>
    /// Product description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;
    /// <summary>
    /// Unique bot deep-linking parameter that can be used to generate this invoice
    /// </summary>
    [JsonPropertyName("start_parameter")]
    public string StartParameter { get; set; } = null!;
    /// <summary>
    /// Three-letter ISO 4217 currency code
    /// </summary>
    [JsonPropertyName("currency")]
    public string Currency { get; set; } = null!;
    /// <summary>
    /// Total price in the smallest units of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145.
    /// </summary>
    [JsonPropertyName("total_amount")]
    public int TotalAmount { get; set; }
}
