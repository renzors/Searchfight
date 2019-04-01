using Searchfight.Engines;

namespace Searchfight.Services
{
    class BingService : SearchService
    {
        public override string Name => "Bing";
        public override ISearchEngine CreateEngine()
        {
            return new BingEngine();
        }
    }
}
