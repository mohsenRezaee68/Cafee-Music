

using _0_Framework.Application;
using musicManagement.Application.Contracts.MusicTrack;
using System.Collections.Generic;

namespace MusicManagement.Application.Contracts.MusicTrack
{
    public interface IMusicTrackApplication
    {
        OperationResult Create(CreateMusicTrack command);
        OperationResult Edit(EditMusicTrack command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditMusicTrack GetDetails(long id);
        List<MusicTrackViewModel> Search(MusicTrackSearchModel searchModel);
    }
}
