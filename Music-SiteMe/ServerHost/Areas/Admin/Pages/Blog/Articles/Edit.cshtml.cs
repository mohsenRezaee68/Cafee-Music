
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServerHost.Areas.Admin.Pages.Blog.Articles
{
    public class EditModel : PageModel
    {
        public EditArticle mohsen;
        public SelectList ArticleCategories;

        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }
        public void OnGet(long id)
        {
            mohsen = _articleApplication.GetDetails(id);
            ArticleCategories = new SelectList(_articleCategoryApplication.GetArticleCategories(), "Id", "Name");
        }
        public IActionResult OnPost(EditArticle command)
        {
            var result = _articleApplication.Edit(command);
            return RedirectToPage("./Index");
        }
    }
}