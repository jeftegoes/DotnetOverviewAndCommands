using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Core.Interfaces
{
    public interface IUpdateService
    {
        Task EchoAsync(Update update);
    }
}