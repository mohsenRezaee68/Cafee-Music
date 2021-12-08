
using _0_Framework.Infrastructure;
using ArtistManagement.Application.Contracts.Artist;
using ArtistManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Artists
{
    public class IndexModel : PageModel
    {
        public ArtistSearchModel SearchModel;
        public List<ArtistViewModel> Artists;
        
        public string Message { get; set; }
        private readonly IArtistApplication _artistApplication;
        

        public IndexModel(IArtistApplication artistApplication)
        {
            _artistApplication = artistApplication;
            
        }
        [NeedsPermission(ArtistPermissions.ListArtist)]
        public void OnGet(ArtistSearchModel searchModel)
        {
           
            Artists = _artistApplication.Search(searchModel);
        }
        [NeedsPermission(ArtistPermissions.DeleteArtist)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _artistApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(ArtistPermissions.NoDeleteArtist)]
        public IActionResult OnGetRestore(long id)
        {
            var result = _artistApplication.Restore(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
