using ASiNet.API.TelegramBot;

namespace Test;

internal class Program
{
    static void Main(string[] args)
    {
        using var bot = new TelegramBotClient("5890196774:AAF7aituj268h7K5ZXS6zbzk8sRp8pruFWU");

        var me = bot.GetMe().Result;

        Console.WriteLine(me);

        Console.ReadKey();
    }
}
