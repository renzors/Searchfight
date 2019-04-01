using Searchfight.Services;

namespace Searchfight.Configuration
{
    interface ISearchServiceFactory
    {
        SearchService[] GetAvailableServices();

        string GetOverAllWinner(SearchService[] services);
    }
}
