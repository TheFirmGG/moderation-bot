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
        private readonly BannedWordsContext _bannedWordsContext;

        public BannedWordsService()
        {
            _bannedWordsContext = new BannedWordsContext();
        }

        public List<BannedWord> GetBannedWords()
        {
            List<BannedWord> bannedWordsList = _bannedWordsContext.BannedWords.ToList();
            return bannedWordsList;
        }

    }
    
}