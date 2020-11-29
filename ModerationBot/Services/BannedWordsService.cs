using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TheFirmGG.Models;

namespace TheFirmGG.Services
{
    public class BannedWordsService
    {
        private List<BannedWord> _currentBannedWords;

        public BannedWordsService(string pathToBannedWordsJsonFile)
        {
            _currentBannedWords = GetBannedWords();
        }

        public List<BannedWord> GetBannedWords()
        {
            List<BannedWord> bannedWordsList = 
            return bannedWordsList;
        }

    }
    
}