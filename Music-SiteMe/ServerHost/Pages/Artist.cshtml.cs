
using _01_LampshadeQuery.Contracts.Artist;
using CommentManagement.Application.Contracts.Comment;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace ServiceHost.Pages
{
    public class ArtistModel : PageModel
    {
        public ArtistQueryModel artist;
        private readonly IArtistQuery _artistQuery;
        private readonly ICommentApplication _commentApplication;
        public ArtistModel(IArtistQuery artistQuery, ICommentApplication commentApplication)
        {
            _artistQuery = artistQuery;
            _commentApplication = commentApplication;
        }
        public void OnGet(string Laghab)
        {
            artist = _artistQuery.GetArtistDetails(Laghab);
           
        }
        public IActionResult OnPost(AddComment command, string id)
        {
            command.Type = CommentType.Artist;
            var result = _commentApplication.Add(command);
            return RedirectToPage("/Artist", new { Id = id });
        }
    }
}
