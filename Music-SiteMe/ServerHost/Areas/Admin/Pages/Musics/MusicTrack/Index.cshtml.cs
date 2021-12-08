

using _0_Framework.Infrastructure;
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
        public IndexModel(IMusicApplication musicApplication, IMusicTrackApplication musicTrackApplication)
        {
            _musicApplication = musicApplication;
            _musicTrackApplication = musicTrackApplication;
        }

        public void OnGet(MusicTrackSearchModel searchModel)
        {
            Musics = new SelectList(_musicApplication.GetMusic(), "Id", "Name");
           
            MusicTracks = _musicTrackApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateMusicTrack
            {
                Musics = _musicApplication.GetMusic()
            };
            return Partial("./Create", command);
        }
        [NeedsPermission(MusicPermissions.CreateAlbom)]
        public JsonResult OnPostCreate(CreateMusicTrack command)
        {
            var result = _musicTrackApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productPicture = _musicTrackApplication.GetDetails(id);
            productPicture.Musics = _musicApplication.GetMusic();
            return Partial("Edit", productPicture);
        }
        [NeedsPermission(MusicPermissions.EditAlbom)]
        public JsonResult OnPostEdit(EditMusicTrack command)
        {
            var result = _musicTrackApplication.Edit(command);
            return new JsonResult(result);
        }
        [NeedsPermission(MusicPermissions.DeleteAlbom)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _musicTrackApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(MusicPermissions.NoDeleteAlbom)]
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
