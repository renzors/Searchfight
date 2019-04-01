using System;

namespace Searchfight.Engines
{
    class GoogleEngine : BaseEngine, ISearchEngine
    {
        public int Search(string word)
        {   
            string key = GetSecretKey("googlekey");
            var url = "https://www.googleapis.com/customsearch/v1?key=" + key + "&q=" + word;
            var result = GetResponse(url);
            return Convert.ToInt32(result["queries"]["request"][0]["totalResults"]);
        }
    }
}
