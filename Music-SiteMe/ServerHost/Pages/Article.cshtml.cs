using _01_LampshadeQuery.Contracts.Article;
using CommentManagement.Application.Contracts.Comment;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleModel : PageModel
    {
        public ArticleQueryModel Article;
        
       
        private readonly IArticleQuery _articleQuery;
       
        private readonly ICommentApplication _commentApplication;

        public ArticleModel(IArticleQuery articleQuery, ICommentApplication commentApplication)
        {
            _articleQuery = articleQuery;
            _commentApplication = commentApplication;
         
        }

        public void OnGet(long id)
        {
            Article = _articleQuery.GetArticleDetails(id);
        }

        public IActionResult OnPost(AddComment command, string id)
        {
            command.Type = CommentType.Article;
            var result = _commentApplication.Add(command);
            return RedirectToPage("/Article", new { Id = id });
        }
    }
}
