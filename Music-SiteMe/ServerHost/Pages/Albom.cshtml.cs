using _01_LampshadeQuery.Contracts.Music;
using CommentManagement.Application.Contracts.Comment;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace ServiceHost.Pages
{
    public class AlbomModel : PageModel
    {
        public MusicQueryModel music;
        private readonly IMusicQuery _musicQuery;
        private readonly ICommentApplication _commentApplication;

        public AlbomModel(IMusicQuery musicQuery, ICommentApplication commentApplication)
        {
            _musicQuery = musicQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(long id)
        {
            music = _musicQuery.GetAlbomDetails(id);
        }

        public IActionResult OnPost(AddComment command, string id)
        {
            command.Type = CommentType.Albom;
            var result = _commentApplication.Add(command);
            return RedirectToPage("/Albom", new { Id = id });
        }
    }
}
