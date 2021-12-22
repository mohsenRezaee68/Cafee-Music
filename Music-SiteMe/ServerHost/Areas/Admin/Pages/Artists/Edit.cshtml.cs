
using _0_Framework.Infrastructure;
using ArtistManagement.Application.Contracts.Artist;
using ArtistManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServerHost.Areas.Admin.Pages.Artists
{
    public class EditModel : PageModel
    {
        private readonly IArtistApplication _artistApplication;
        public EditArtist Artist;

        public EditModel(IArtistApplication artistApplication)
        {
            _artistApplication = artistApplication;

        }
          public void OnGetEdit(long id)
          {
              Artist = _artistApplication.GetDetails(id);
              
          }
          
          public IActionResult OnPostEdit(EditArtist command)
          {
              var result = _artistApplication.Edit(command);
              return RedirectToPage("./Index");
          }


       
    }
}
