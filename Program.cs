using System;
using Discord.WebSocket;
using Discord;
using System.Threading.Tasks;


namespace OverwatchBot
{
    public class Program
    {
        private DiscordSocketClient _client;
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;

            await _client.LoginAsync(TokenType.Bot,"NzAxODcxODQ1NTc3ODUxMDAy.Xp32zg.nf-U9VfRrHtO92E3BRZPkZ7Q8Pc");
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
