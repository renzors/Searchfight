using Searchfight.Engines;

namespace Searchfight.Services
{
    class GoogleService : SearchService
    {
        public override string Name => "Google";

        public override ISearchEngine CreateEngine()
        {
            return new GoogleEngine();
        }
    }
}
