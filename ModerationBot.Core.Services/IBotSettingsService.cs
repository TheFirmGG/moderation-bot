using System.Collections;
using System.Collections.Generic;
using TheFirmGG.ModerationBot.Core.Models;

namespace TheFirmGG.ModerationBot.Core.Services
{
    public interface IBotSettingsService
    {
        public BotSetting GetSettingById(int id);
        public IEnumerable<BotSetting> GetSettings();
        public BotSetting CreateSetting(BotSetting settingToCreate);
        public BotSetting UpdateSetting(BotSetting settingToUpdate);
        public BotSetting DeleteSettingById(int id);
    }
}