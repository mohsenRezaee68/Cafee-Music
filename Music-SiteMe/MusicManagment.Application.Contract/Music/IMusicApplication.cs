using _0_Framework.Application;
using System.Collections.Generic;

namespace MusicManagement.Application.Contracts.Music
{
    public interface IMusicApplication
    {
        OperationResult Create(CreateMusic command);
        OperationResult Edit(EditMusic command);
        EditMusic GetDetails(long id);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        List<MusicViewModel> GetMusic();
        List<MusicViewModel> Search(MusicSearchModel searchModel);
    }
}
