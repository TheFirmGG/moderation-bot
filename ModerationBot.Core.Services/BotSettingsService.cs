using System.Collections.Generic;
using System.Linq;
using TheFirmGG.ModerationBot.Core.Models;
using TheFirmGG.ModerationBot.EntityFramework;

namespace TheFirmGG.ModerationBot.Core.Services
{
    public class BotSettingsService : IBotSettingsService
    {

        public BotSetting GetSettingById(int id)
        {
            using var moderationBotContext = new ModerationBotContext();
            var result = moderationBotContext.Settings.Find(id);
            return result;
        }

        public IEnumerable<BotSetting> GetSettings()
        {
            using var moderationBotContext = new ModerationBotContext();
            return moderationBotContext.Settings.ToList();
        }

        public BotSetting CreateSetting(BotSetting settingToCreate)
        {
            using var moderationBotContext = new ModerationBotContext();
            moderationBotContext.Settings.Add(settingToCreate);
            moderationBotContext.SaveChanges();
            return settingToCreate;
        }

        public BotSetting UpdateSetting(BotSetting settingToUpdate)
        {
            using var moderationBotContext = new ModerationBotContext();
            moderationBotContext.Settings.Update(settingToUpdate);
            moderationBotContext.SaveChanges();
            return settingToUpdate;
        }

        public BotSetting DeleteSettingById(int id)
        {
            using var moderationBotContext = new ModerationBotContext();
            var settingToDelete = GetSettingById(id);
            moderationBotContext.Settings.Remove(settingToDelete);
            moderationBotContext.SaveChanges();
            return settingToDelete;
        }
    }
}