using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace TheFirmGG
{
    class ModerationBot
    {
        public const String DiscordAuthTokenEnvVariableName = "DISCORD_AUTH_TOKEN";
        
        private DiscordSocketClient _client;

        public static void Main(string[] args)
            => new ModerationBot().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;
            _client.MessageReceived += MessageReceived;
            
            await _client.LoginAsync(TokenType.Bot, Environment.GetEnvironmentVariable(DiscordAuthTokenEnvVariableName));
            await _client.StartAsync();

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        private async Task MessageReceived(SocketMessage msg)
        {
            Console.WriteLine(msg.Content);
            if (Regex.IsMatch(msg.Content, @"\bbig dumb idiothead\b"))
            {
                await msg.DeleteAsync();
                await msg.Channel.SendMessageAsync("Removed a message with a banned word posted by <@" +
                                                   msg.Author.Id + ">");
            }
        }
        
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}