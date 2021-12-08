

using _0_Framework.Application;
using System.Collections.Generic;

namespace ArtistManagement.Application.Contracts.Artist
{
    public interface IArtistApplication
    {
        OperationResult Create(CreateArtist command);
        OperationResult Edit(EditArtist command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditArtist GetDetails(long id);
        List<ArtistViewModel> GetList();
        List<ArtistViewModel> Search(ArtistSearchModel searchModel);
    }
}
