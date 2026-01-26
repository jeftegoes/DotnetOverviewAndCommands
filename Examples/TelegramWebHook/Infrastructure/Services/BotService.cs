using Microsoft.Extensions.Options;
using Core.Entites;
using Core.Interfaces;
using Telegram.Bot;

namespace Infrastructure.Services
{
    public class BotService : IBotService
    {
        private readonly BotConfiguration _config;
        public TelegramBotClient Client { get; }

        public BotService(IOptions<BotConfiguration> config)
        {
            _config = config.Value;

            Client = new TelegramBotClient(_config.BotToken);

        }
    }
}