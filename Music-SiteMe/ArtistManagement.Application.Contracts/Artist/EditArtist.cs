using ArtistManagement.Application.Contracts.Artist;

namespace ArtistManagement.Application.Contracts.Artist
{
    public class EditArtist : CreateArtist
    {
        public long Id { get; set; }
    }
}