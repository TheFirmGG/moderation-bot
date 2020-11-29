using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using TheFirmGG.EntityFramework.Models;
using TheFirmGG.Services;

namespace TheFirmGG
{
    class ModerationBot
    {
        public const String DiscordAuthTokenEnvVariableName = "MODERATION_BOT_DISCORD_AUTH_TOKEN";
        
        private DiscordSocketClient _client;
        private BannedWordsService _bannedWordsService;

        public static void Main(string[] args)
            => new ModerationBot().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _bannedWordsService = new BannedWordsService();
            _client = new DiscordSocketClient();

            //_client.Log += Log;
            _client.MessageReceived += MessageReceived;
            
            await _client.LoginAsync(TokenType.Bot, Environment.GetEnvironmentVariable(DiscordAuthTokenEnvVariableName));
            await _client.StartAsync();

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        private async Task MessageReceived(SocketMessage msg)
        {
            // Grab list of banned words
            List<BannedWord> bannedWords = _bannedWordsService.GetBannedWords();

            foreach (var bannedWord in bannedWords)
            {
                if (Regex.IsMatch(msg.Content, bannedWord.BannedWordRegex))
                {
                    await msg.DeleteAsync();
                    await msg.Channel.SendMessageAsync("Removed a message with a banned word posted by <@" +
                                                       msg.Author.Id + ">");
                }
            }
        }
        
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
