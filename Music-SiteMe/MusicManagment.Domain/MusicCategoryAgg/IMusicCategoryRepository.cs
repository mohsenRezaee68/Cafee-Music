

using _0_Framework.Domain;
using MusicManagement.Application.Contracts.MusicCategory;
using System.Collections.Generic;

namespace MusicManagement.Domain.MusicCategoryAgg
{
    public interface IMusicCategoryRepository : IRepository<long, MusicCategory>
    {
      
        List<MusicCategoryViewModel> GetMusicCategories();
        EditMusicCategory GetDetails(long id);
        string GetSlugById(long id);
        List<MusicCategoryViewModel> Search(MusicCategorySearchModel searchModel);
    }
}
