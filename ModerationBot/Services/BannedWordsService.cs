using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using TheFirmGG.EntityFramework;
using TheFirmGG.EntityFramework.Models;

namespace TheFirmGG.Services
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