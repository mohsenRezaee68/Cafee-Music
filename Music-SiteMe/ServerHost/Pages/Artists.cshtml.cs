using _01_LampshadeQuery.Contracts.Artist;

using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class ArtistsModel : PageModel
    {

        private readonly IArtistQuery _artistQuery;
        public List<ArtistQueryModel> artistSerch;
        public List<ArtistQueryModel> artist;
        public string values = null;
        public ArtistsModel(IArtistQuery artistQuery)
        {
            _artistQuery = artistQuery;
        }
         public void OnGet(string value)
        {
            values = value;
            artist = _artistQuery.LatestArtistAlls();
            artistSerch = _artistQuery.SearchArtists(value);

        }
    }
}
