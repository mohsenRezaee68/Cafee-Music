

using _0_Framework.Application;
using System.Collections.Generic;

namespace MusicManagement.Application.Contracts.MusicCategory
{
    public interface IMusicCategoryApplication
    {
        OperationResult Create(CreateMusicCategory command);
        OperationResult Edit(EditMusicCategory command);
        EditMusicCategory GetDetails(long id);
        List<MusicCategoryViewModel> GetMusicCategories();
        List<MusicCategoryViewModel> Search(MusicCategorySearchModel searchModel);
    }
}
