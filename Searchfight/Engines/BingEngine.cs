using System;

namespace Searchfight.Engines
{
    class BingEngine : BaseEngine, ISearchEngine
    {
        public int Search(string word)
        {
            string key = GetSecretKey("bingkey");
            var url = "https://api.cognitive.microsoft.com/bingcustomsearch/v7.0/search" + "?q=" + word + "&customconfig=0";            
            AddHeader("Ocp-Apim-Subscription-Key", key);
            var result = GetResponse(url);
            return Convert.ToInt32(result["webPages"]["totalEstimatedMatches"]);
        }
    }
}
