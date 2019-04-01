using System;

namespace Searchfight.Engines
{
    class GoogleEngine : BaseEngine, ISearchEngine
    {
        public int Search(string word)
        {
            string key = "AIzaSyAYKBLINxMWiEeXSjNeyFxzGjYKBfLwpnE&cx=006469441686315824696:jlvbuea85y8";
            var url = "https://www.googleapis.com/customsearch/v1?key=" + key + "&q=" + word;
            var result = GetResponse(url);
            return Convert.ToInt32(result["queries"]["request"][0]["totalResults"]);
        }
    }
}
