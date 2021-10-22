

using _0_Framework.Domain;
using musicManagement.Application.Contracts.MusicTrack;
using MusicManagement.Application.Contracts.MusicTrack;
using System.Collections.Generic;

namespace MusicManagement.Domain.MusicTrackAgg
{
    public interface IMusicTrackRepository : IRepository<long, MusicTrack>
    {
        EditMusicTrack GetDetails(long id);
        MusicTrack GetWithMusicAndCategory(long id);
        List<MusicTrackViewModel> Search(MusicTrackSearchModel searchModel);
    }
}
