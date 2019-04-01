using Searchfight.Services;
using System.Collections.Generic;
using System.Linq;

namespace Searchfight.Configuration
{
    class SearchServiceConfiguration : ISearchServiceFactory
    {        
        public SearchService[] GetAvailableServices()
        {
            return new SearchService[] {
                new GoogleService(),
                new BingService()
            };
        }

        public string GetOverAllWinner(SearchService[] services)
        {
            var winners = new List<string>();

            foreach (var service in services)
                winners.Add(service.GetWinner());

            return winners.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }
    }
}
