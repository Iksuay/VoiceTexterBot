using Telegram.Bot;
using Telegram.Bot.Types;

namespace VoiceTexterBot.Controllers
{
    public class InlineKeyboardController
    {
        private readonly ITelegramBotClient _telegramClient;

        public InlineKeyboardController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(CallbackQuery? callbackQuery, CancellationToken ct)
        {
            Console.WriteLine($"���������� {GetType().Name} ��������� ������� �� ������");

            await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"���������� ������� �� ������", cancellationToken: ct);
        }
    }
}