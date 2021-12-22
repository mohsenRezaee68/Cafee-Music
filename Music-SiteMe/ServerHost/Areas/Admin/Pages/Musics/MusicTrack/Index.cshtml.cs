

using _0_Framework.Application;
using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using musicManagement.Application.Contracts.MusicTrack;
using MusicManagement.Application.Contracts.Music;
using MusicManagement.Application.Contracts.MusicTrack;
using MusicManagement.Configuration.Permissions;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Musics.MusicTrack
{
    [Authorize(Roles = "1 , 2")]
    public class IndexModel : PageModel
    {
        
        [TempData]
        public string Message { get; set; }
        public MusicTrackSearchModel SearchModel;
        public List<MusicTrackViewModel> MusicTracks;
        public SelectList Musics;
        public SelectList MusicsTrack;
        private readonly IMusicApplication _musicApplication;
        private readonly IMusicTrackApplication _musicTrackApplication;
        private readonly IAuthHelper _authHelper;
        private readonly IAccountQuery _accountquery;
        public AccountQueryModel music;
        public IndexModel(IAccountQuery accountquery, IAuthHelper authHelper, IMusicApplication musicApplication, IMusicTrackApplication musicTrackApplication)
        {
            _musicApplication = musicApplication;
            _musicTrackApplication = musicTrackApplication;
            _accountquery = accountquery;
            _authHelper = authHelper;
        }

        public void OnGet(MusicTrackSearchModel searchModel)
        {
            Musics = new SelectList(_musicApplication.GetMusic(), "Id", "Name");
           
            MusicTracks = _musicTrackApplication.Search(searchModel);
        }
        [NeedsPermission(MusicPermissions.SerchTrack)]
        public IActionResult OnGetCreate()
        {
            var command = new CreateMusicTrack
            {
                Musics = _musicApplication.GetMusic()
            };
            return Partial("./Create", command);
        }
        [NeedsPermission(MusicPermissions.CreatTrack)]
        public JsonResult OnPostCreate(CreateMusicTrack command)
        {
            long currentAccountId = _authHelper.CurrentAccountId();
            music = _accountquery.GetAccount(currentAccountId);
            command.Frestande = music.UserName;
            var result = _musicTrackApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productPicture = _musicTrackApplication.GetDetails(id);
            productPicture.Musics = _musicApplication.GetMusic();
            return Partial("Edit", productPicture);
        }
        [NeedsPermission(MusicPermissions.EditeTrack)]
        public JsonResult OnPostEdit(EditMusicTrack command)
        {
            var result = _musicTrackApplication.Edit(command);
            return new JsonResult(result);
        }
        [NeedsPermission(MusicPermissions.RemoveTrack)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _musicTrackApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(MusicPermissions.RestorTrack)]
        public IActionResult OnGetRestore(long id)
        {
            var result = _musicTrackApplication.Restore(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
