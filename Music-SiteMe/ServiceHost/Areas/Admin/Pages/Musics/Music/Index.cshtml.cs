

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicManagement.Application.Contracts.Music;
using MusicManagement.Application.Contracts.MusicCategory;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Musics.Music
{
    public class IndexModel : PageModel
    {
        
        [TempData]
        
        public string Message { get; set; }
        public SelectList MusicCategories;
        public MusicSearchModel SearchModel;
        public List<MusicViewModel> Musics;
        private readonly IMusicApplication _musicApplication;
        private readonly IMusicCategoryApplication _musicCategoryApplication;
        public IndexModel(IMusicApplication musicApplication , IMusicCategoryApplication musicCategoryApplication)
        {
            _musicApplication = musicApplication;
            _musicCategoryApplication = musicCategoryApplication;
        }
        public void OnGet(MusicSearchModel searchModel)
        {
            MusicCategories = new SelectList(_musicCategoryApplication.GetMusicCategories(),"Id","Name");
            Musics = _musicApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
           var  command = new CreateMusic()
            {
                Categories = _musicCategoryApplication.GetMusicCategories()
            };
            return Partial("./Create", command);
        }
       // [NeedsPermission(ShopPermissions.CreateProduct)]
        public JsonResult OnPostCreate(CreateMusic command)
        {
            var result = _musicApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var product = _musicApplication.GetDetails(id);
            product.Categories = _musicCategoryApplication.GetMusicCategories();
            return Partial("Edit", product);
        }

       // [NeedsPermission(ShopPermissions.EditProductCategory)]
        public JsonResult OnPostEdit(EditMusic command)
        {
            if (ModelState.IsValid)
            {
            }

            var result = _musicApplication.Edit(command);
            return new JsonResult(result);
        }
      // public IActionResult onGetNotInStock(long id)
      // {
      //    var result = _productApplication.NotInStock(id);
      //     if (result.IsSuccedded)
      //         return RedirectToPage("./Index");
      //     Message = result.Message;
      //     return RedirectToPage("./Index");
      // }
      // public IActionResult onGetIsInStock(long id)
      // {
      //  var result = _productApplication.IsStock(id);
      //     if (result.IsSuccedded)
      //         return RedirectToPage("./Index");
      //     Message = result.Message;
      //     return RedirectToPage("./Index");
      // }
    }
}