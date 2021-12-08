
using _01_LampshadeQuery.Contracts.Artist;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class Artist : ViewComponent
    {
        private readonly IArtistQuery _artistQuery;

        public Artist(IArtistQuery artistQuery)
        {
            _artistQuery = artistQuery;
        }

        public IViewComponentResult Invoke()
        {
            var artist = _artistQuery.LatestArtists();
            return View(artist);
        }
    }
}
