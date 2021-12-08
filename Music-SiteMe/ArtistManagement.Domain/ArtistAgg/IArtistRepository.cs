

using _0_Framework.Domain;
using ArtistManagement.Application.Contracts.Artist;

using System.Collections.Generic;

namespace ArtistManagement.Domain.ArtistAgg
{
    public interface IArtistRepository : IRepository<long, Artist>
    {
        EditArtist GetDetails(long id);
        List<ArtistViewModel> GetList();
        List<ArtistViewModel> Search(ArtistSearchModel searchModel);
        
       
    }
}
