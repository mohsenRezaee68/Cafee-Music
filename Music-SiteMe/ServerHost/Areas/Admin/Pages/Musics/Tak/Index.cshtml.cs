

using _0_Framework.Application;
using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Account;
using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicManagement.Application.Contracts.MusicCategory;
using MusicManagement.Application.Contracts.Tak;
using MusicManagement.Configuration.Permissions;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Musics.Tak
{
    [Authorize(Roles = "1 , 2")]
    public class IndexModel : PageModel
    {
        
        [TempData]
      
        public string Message { get; set; }
        public AccountQueryModel music;
        public SelectList MusicCategories;
        public TakSearchModel SearchModel;
        private readonly IMusicQuery _musicQuery;
        public List<TakViewModel> Taks;
        public takViewforadmin Albooms;
        public string Value = null;
        private readonly ITakApplication _takApplication;
        private readonly IMusicCategoryApplication _musicCategoryApplication;
        private readonly IAuthHelper _authHelper;
        private readonly IAccountQuery _accountquery;
        public IndexModel(IAccountQuery accountquery, ITakApplication takApplication , IMusicCategoryApplication musicCategoryApplication, IMusicQuery musicQuery, IAuthHelper authHelper)
        {
            _accountquery = accountquery;
            _musicQuery = musicQuery;
            _takApplication = takApplication;
            _musicCategoryApplication = musicCategoryApplication;
            _authHelper = authHelper;
        }
        [NeedsPermission(MusicPermissions.SerchTakAhang)]
        public void OnGet(TakSearchModel searchModel)
        {
            if(searchModel != null) { Value = "nall"; }
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
        [NeedsPermission(MusicPermissions.CreatTakAhang)]
        public JsonResult OnPostCreate(CreateTak command )
        {
            long currentAccountId = _authHelper.CurrentAccountId();
            music = _accountquery.GetAccount(currentAccountId);
             command.Ferestande = music.UserName;
            var result = _takApplication.Create(command );
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _takApplication.GetDetails(id);
            productCategory.Categories = _musicCategoryApplication.GetMusicCategories();
            return Partial("Edit", productCategory);

        }

       [NeedsPermission(MusicPermissions.EditTakAhang)]
        public JsonResult OnPostEdit(EditTak command)
        {
            var result = _takApplication.Edit(command);
            return new JsonResult(result);

        }


        [NeedsPermission(MusicPermissions.RemovTakAhang)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _takApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(MusicPermissions.RestorTakAhang)]
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