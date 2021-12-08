

using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicManagement.Application.Contracts.MusicCategory;
using MusicManagement.Application.Contracts.Tak;
using MusicManagement.Configuration.Permissions;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Musics.Tak
{
    public class IndexModel : PageModel
    {
        
        [TempData]
        
        public string Message { get; set; }
        public SelectList MusicCategories;
        public TakSearchModel SearchModel;
        public List<TakViewModel> Taks;
        private readonly ITakApplication _takApplication;
        private readonly IMusicCategoryApplication _musicCategoryApplication;
        public IndexModel(ITakApplication takApplication , IMusicCategoryApplication musicCategoryApplication)
        {
            _takApplication = takApplication;
            _musicCategoryApplication = musicCategoryApplication;
        }
        public void OnGet(TakSearchModel searchModel)
        {
            MusicCategories = new SelectList(_musicCategoryApplication.GetMusicCategories(),"Id","Name");
            Taks = _takApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
           var  command = new CreateTak()
            {
                Categories = _musicCategoryApplication.GetMusicCategories()
            };
            return Partial("./Create", command);
        }
        [NeedsPermission(MusicPermissions.CreateTrack)]
        public JsonResult OnPostCreate(CreateTak command)
        {
            var result = _takApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var product = _takApplication.GetDetails(id);
            product.Categories = _musicCategoryApplication.GetMusicCategories();
            return Partial("Edit", product);
        }

       [NeedsPermission(MusicPermissions.EditTrack)]
        public JsonResult OnPostEdit(EditTak command)
        {
            if (ModelState.IsValid)
            {
            }

            var result = _takApplication.Edit(command);
            return new JsonResult(result);
        }
        [NeedsPermission(MusicPermissions.DeleteTrack)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _takApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(MusicPermissions.NoDeleteTrack)]
        public IActionResult OnGetRestore(long id)
        {
            var result = _takApplication.Restore(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
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