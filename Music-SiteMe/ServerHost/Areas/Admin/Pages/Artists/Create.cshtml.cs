

using _0_Framework.Infrastructure;
using ArtistManagement.Application.Contracts.Artist;
using ArtistManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Artists
{
    [Authorize(Roles = "1 , 2")]
    public class CreateModel : PageModel
    {
        public CreateArtist Command;
       

        private readonly IArtistApplication _artistApplication;
       

        public CreateModel(IArtistApplication artistApplication)
        {
            _artistApplication = artistApplication;
            
        }
        public void OnGet()
        {
            
        }
        [NeedsPermission(ArtistPermissions.CreateArtist)]
        public IActionResult OnPost(CreateArtist command)
        {
            var result = _artistApplication.Create(command);
            return RedirectToPage("./Index");
        }
    }
}
