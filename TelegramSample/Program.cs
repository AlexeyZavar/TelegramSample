using Microsoft.Extensions.DependencyInjection;
using TelegramBotBase.Builder;
using TelegramSample.Forms;

var serviceCollection = new ServiceCollection();

var serviceProvider = serviceCollection
    // some services here
    .BuildServiceProvider();

var bot = BotBaseBuilder.Create()
                        .WithAPIKey(Environment.GetEnvironmentVariable("API_KEY") ?? throw new Exception("API_KEY is not set"))
                        .DefaultMessageLoop()
                        .WithServiceProvider<StartForm>(serviceProvider)
                        .NoProxy()
                        .NoCommands()
                        .NoSerialization()
                        .DefaultLanguage()
                        .Build();

await bot.Start();
await Task.Delay(-1);
