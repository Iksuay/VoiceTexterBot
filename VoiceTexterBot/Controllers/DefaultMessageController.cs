using Telegram.Bot;
using Telegram.Bot.Types;

namespace VoiceTexterBot.Controllers
{
    public class DefaultMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public DefaultMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"���������� {GetType().Name} ������� ���������");
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"�������� ��������� �� ��������������� �������", cancellationToken: ct);
        }
    }
}