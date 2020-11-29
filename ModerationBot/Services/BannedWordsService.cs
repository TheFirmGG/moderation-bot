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
        private List<BannedWord> _currentBannedWords;
        private BannedWordsContext _bannedWordsContext;

        public BannedWordsService()
        {
            _currentBannedWords = GetBannedWords();
            _bannedWordsContext = new BannedWordsContext();
        }

        public List<BannedWord> GetBannedWords()
        {
            List<BannedWord> bannedWordsList = _bannedWordsContext.BannedWords.ToList();
            return bannedWordsList;
        }

    }
    
}