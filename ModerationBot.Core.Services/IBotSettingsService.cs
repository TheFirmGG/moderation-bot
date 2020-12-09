using System.Collections;
using System.Collections.Generic;
using TheFirmGG.ModerationBot.Core.Models;

namespace TheFirmGG.ModerationBot.Core.Services
{
    public interface IBotSettingsService
    {
        public IEnumerable<BotSetting> GetSettings();
        public BotSetting CreateSetting(BotSetting settingToCreate);
    }
}