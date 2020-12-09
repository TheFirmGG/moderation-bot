using System.Collections.Generic;
using System.Linq;
using TheFirmGG.ModerationBot.Core.Models;
using TheFirmGG.ModerationBot.EntityFramework;

namespace TheFirmGG.ModerationBot.Core.Services
{
    public class BannedWordsService
    {
        public BannedWordsService()
        {
        }

        public List<BannedWord> GetBannedWords()
        {
            ModerationBotContext bannedWordsContext = new ModerationBotContext();
            List<BannedWord> bannedWordsList = bannedWordsContext.BannedWords.ToList();
            return bannedWordsList;
        }

    }
    
}