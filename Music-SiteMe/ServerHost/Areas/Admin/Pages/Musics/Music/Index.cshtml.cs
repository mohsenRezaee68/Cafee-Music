

using _0_Framework.Application;
using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicManagement.Application.Contracts.Music;
using MusicManagement.Application.Contracts.MusicCategory;
using MusicManagement.Configuration.Permissions;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Musics.Music
{
    [Authorize(Roles = "1 , 2")]
    public class IndexModel : PageModel
    {
        
        [TempData]
        
        public string Message { get; set; }
        public SelectList MusicCategories;
        public MusicSearchModel SearchModel;
        public List<MusicViewModel> Musics;
        private readonly IMusicApplication _musicApplication;
        private readonly IMusicCategoryApplication _musicCategoryApplication;
        private readonly IAuthHelper _authHelper;
        private readonly IAccountQuery _accountquery;
        public AccountQueryModel music;
        public IndexModel(IAccountQuery accountquery, IAuthHelper authHelper, IMusicApplication musicApplication , IMusicCategoryApplication musicCategoryApplication)
        {
            _musicApplication = musicApplication;
            _musicCategoryApplication = musicCategoryApplication;
            _accountquery = accountquery;
            _authHelper = authHelper;
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
        [NeedsPermission(MusicPermissions.CreatAlbom)]
        public JsonResult OnPostCreate(CreateMusic command)
        {

            long currentAccountId = _authHelper.CurrentAccountId();
            music = _accountquery.GetAccount(currentAccountId);
            command.Ferestande = music.UserName;
            var result = _musicApplication.Create(command);
            return new JsonResult(result);
        }



        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _musicApplication.GetDetails(id);
            productCategory.Categories = _musicCategoryApplication.GetMusicCategories();
            return Partial("Edit", productCategory);
        }
       

        [NeedsPermission(MusicPermissions.EditeAlbom)]
        public JsonResult OnPostEdit(EditMusic command)
        {
            var result = _musicApplication.Edit(command);
            return new JsonResult(result);
        }



        [NeedsPermission(MusicPermissions.RemoveAlbom)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _musicApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(MusicPermissions.RestorAlbom)]
        public IActionResult OnGetRestore(long id)
        {
            var result = _musicApplication.Restore(id);
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