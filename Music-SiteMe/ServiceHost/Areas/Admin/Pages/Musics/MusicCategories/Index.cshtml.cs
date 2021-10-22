
using System.Collections.Generic;

using _0_Framework.Infrastructure;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicManagement.Application.Contracts.MusicCategory;

namespace ServiceHost.Areas.Admin.Pages.Musics.MusicCategories
{
  // [Authorize]
    public class IndexModel : PageModel
    {
        public MusicCategorySearchModel SearchModel;
        public List<MusicCategoryViewModel> MusicCategories;
        private readonly IMusicCategoryApplication _musicCategoryApplication;
        public IndexModel(IMusicCategoryApplication musicCategoryApplication)
        {
            _musicCategoryApplication = musicCategoryApplication;
        }
       // [NeedsPermission(ShopPermissions.ListProductCategories)]
        public void OnGet(MusicCategorySearchModel searchModel)
        {
            MusicCategories = _musicCategoryApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateMusicCategory());
        }
       // [NeedsPermission(ShopPermissions.CreateProductCategory)]
        public JsonResult OnPostCreate(CreateMusicCategory command)
        {
            var result = _musicCategoryApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _musicCategoryApplication.GetDetails(id);
            return Partial("Edit", productCategory);
        }

       // [NeedsPermission(ShopPermissions.EditProductCategory)]
        public JsonResult OnPostEdit(EditMusicCategory command)
        {
            if (ModelState.IsValid)
            {
            }

            var result = _musicCategoryApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}