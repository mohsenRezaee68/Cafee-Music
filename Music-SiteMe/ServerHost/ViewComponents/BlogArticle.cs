using _01_LampshadeQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BlogArticle : ViewComponent
    {
        private readonly IArticleQuery _articleQuery;

        public BlogArticle(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public IViewComponentResult Invoke()
        {
            var article = _articleQuery.LatestArticles();
            return View(article);
        }
    }
}
