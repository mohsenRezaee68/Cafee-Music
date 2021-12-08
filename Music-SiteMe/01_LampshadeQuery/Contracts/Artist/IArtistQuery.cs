using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Artist
{
    public interface IArtistQuery
    {
        List<ArtistQueryModel> LatestArtists();
        ArtistQueryModel GetArtistDetails(string Laghab);
        List<ArtistQueryModel> LatestArtistAlls();
        List<ArtistQueryModel> SearchArtists(string value);
    }
}
