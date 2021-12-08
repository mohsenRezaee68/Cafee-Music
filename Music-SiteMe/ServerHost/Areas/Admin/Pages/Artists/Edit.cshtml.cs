
using ArtistManagement.Application.Contracts.Artist;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.Artists
{
    public class EditModel : PageModel
    {
        public EditArtist Command;
       

        private readonly IArtistApplication _artistApplication;
       

        public EditModel(IArtistApplication artistApplication)
        {
            _artistApplication = artistApplication;
           
        }

        public void OnGet(long id)
        {
            Command = _artistApplication.GetDetails(id);
            
        }

        public IActionResult OnPost(EditArtist command)
        {
            var result = _artistApplication.Edit(command);
            return RedirectToPage("./Index");
        }
    }
}
