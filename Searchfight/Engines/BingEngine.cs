using System;

namespace Searchfight.Engines
{
    class BingEngine : BaseEngine, ISearchEngine
    {
        public int Search(string word)
        {         
            var url = "https://api.cognitive.microsoft.com/bingcustomsearch/v7.0/search" + "?q=" + word + "&customconfig=0";
            AddHeader("Ocp-Apim-Subscription-Key", "dfdc2c99146c4e22b95412984e76ac40");
            var result = GetResponse(url);
            return Convert.ToInt32(result["webPages"]["totalEstimatedMatches"]);
        }
    }
}
