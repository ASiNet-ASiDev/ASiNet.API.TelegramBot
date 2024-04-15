using System.Net;
using System.Net.Http.Json;
using ASiNet.API.TelegramBot.Base;
using ASiNet.API.TelegramBot.Enums;
using ASiNet.API.TelegramBot.Primitives;
using Microsoft.AspNetCore.WebUtilities;

namespace ASiNet.API.TelegramBot;

public class TelegramBotClient : IDisposable
{
    public TelegramBotClient(string token)
    {
        _client = new()
        {
            BaseAddress = new Uri($"{TELEGRAM_HOST_URI}bot{token}/")
        };
    }

    public int UpdatesLimit { get; set; } = 100;

    public TimeSpan UpdatesTimeout { get; set; } = TimeSpan.FromSeconds(5);

    private const string TELEGRAM_HOST_URI = "https://api.telegram.org/";

    private HttpClient _client;

    private ulong _offset;

    public async Task<User> GetMe(CancellationToken token = default)
    {
        var msg = await _client.GetAsync("getMe", token);
        
        if(msg.StatusCode != HttpStatusCode.OK)
            throw new Exception(msg.StatusCode.ToString());

        var result = await msg.Content.ReadFromJsonAsync<TelegramResponse<User>>(token) ?? throw new NullReferenceException();

        if (result.Ok)
            return result.Result!;
        throw new Exception($"{(HttpStatusCode?)result.ErrorCode}: {result.Description}");
    }

    public async IAsyncEnumerable<Update> GetUpdates(UpdateType allowUpdates = UpdateType.Message | UpdateType.EditedChannelPost | UpdateType.CallbackQuery)
    {
        var msg = await _client.GetAsync(QueryHelpers.AddQueryString("getUpdates", 
            [
                KeyValuePair.Create<string, string?>("offset", _offset.ToString()),
                KeyValuePair.Create<string, string?>("limit", UpdatesLimit.ToString()),
                KeyValuePair.Create<string, string?>("timeout", UpdatesTimeout.Seconds.ToString()),
                KeyValuePair.Create<string, string?>("allowed_updates", UpdateHelper.GetAllowUpdatesString(allowUpdates)),
            ]));

        yield break;
    }


    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}
