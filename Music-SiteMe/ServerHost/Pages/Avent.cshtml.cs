using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.ArticleCategory;
using _01_LampshadeQuery.Contracts.Music;
using CommentManagement.Application.Contracts.Comment;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ServiceHost.Pages
{
    public class AventModel : PageModel
    {
        public ArticleQueryModel Avent;
        public BlogAventViowModel avent;

        private readonly IArticleQuery _articleQuery;
       
        private readonly ICommentApplication _commentApplication;

        public AventModel(IArticleQuery articleQuery, ICommentApplication commentApplication)
        {
            _articleQuery = articleQuery;
            _commentApplication = commentApplication;
         
        }

        public void OnGet(long id, int pageId = 1)
        {
           Avent = _articleQuery.GetAventDetails(id);
            
        }

        public IActionResult OnPost(AddComment command, string id)
        {
            command.Type = CommentType.Avent;
            var result = _commentApplication.Add(command);
            return RedirectToPage("/Avent", new { Id = id });
        }
    }
}
