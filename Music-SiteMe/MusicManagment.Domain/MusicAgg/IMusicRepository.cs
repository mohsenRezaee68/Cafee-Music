

using _0_Framework.Domain;
using MusicManagement.Application.Contracts.Music;
using System.Collections.Generic;

namespace MusicManagement.Domain.MusicAgg
{
    public interface IMusicRepository : IRepository<long, Music>
    {
        EditMusic GetDetails(long id);
       Music GetMusicWithCategory(long id);
        List<MusicViewModel> GetMusics();
        List<MusicViewModel> Search(MusicSearchModel searchModel);
    }
}
