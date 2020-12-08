using System;
using Microsoft.EntityFrameworkCore;
using TheFirmGG.EntityFramework.Models;

namespace TheFirmGG.EntityFramework
{
    public class ModerationBotContext : DbContext
    {
        public const string DatabaseHostEnvArgName = "MODERATION_BOT_DATABASE_HOST";
        public const string DatabaseNameEnvArgName = "MODERATION_BOT_DATABASE_NAME";
        public const string DatabaseUsernameEnvArgName = "MODERATION_BOT_DATABASE_USERNAME";
        public const string DatabasePasswordEnvArgName = "MODERATION_BOT_DATABASE_PASSWORD";
        
        public DbSet<BannedWord> BannedWords { get; set; }
        public DbSet<BotSetting> Settings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbHost = Environment.GetEnvironmentVariable(DatabaseHostEnvArgName);
            string dbName = Environment.GetEnvironmentVariable(DatabaseNameEnvArgName);
            string dbUsername = Environment.GetEnvironmentVariable(DatabaseUsernameEnvArgName);
            string dbPassword = Environment.GetEnvironmentVariable(DatabasePasswordEnvArgName);
            
            optionsBuilder.UseNpgsql($"Host={dbHost};Database={dbName};Username={dbUsername};Password={dbPassword}");
        }
    }
}