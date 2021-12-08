

using ArtistManagement.Application.Contracts.Artist;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Artists
{
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
        public IActionResult OnPost(CreateArtist command)
        {
            var result = _artistApplication.Create(command);
            return RedirectToPage("./Index");
        }
    }
}
