using Telegram.Bot;

namespace Core.Interfaces
{
    public interface IBotService
    {
        TelegramBotClient Client { get; }
    }
}