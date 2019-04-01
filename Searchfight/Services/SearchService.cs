using Searchfight.Engines;

namespace Searchfight.Services
{
    abstract class SearchService
    {
        public abstract ISearchEngine CreateEngine();
        public abstract string Name { get; }

        private string Winner = "Without results";

        private int WinnerResults = 0;

        public string GetWinner()
        {
            return Winner;
        }

        public string WinnerToString()
        {
            return $"{Name} winner : {Winner}";
        }

        public string GetResults(string word)
        {
            var engine = CreateEngine();

            var results = engine.Search(word);

            SetWinner(word, results);

            return $"{Name} : {results}";
        }

        private void SetWinner(string word, int results)
        {
            if(results > WinnerResults)
            {
                Winner = word;
                WinnerResults = results;
            }
        }
    }
}
