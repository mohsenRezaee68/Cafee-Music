using _01_LampshadeQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BlogAvent : ViewComponent
    {
        private readonly IArticleQuery _articleQuery;

        public BlogAvent(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public IViewComponentResult Invoke()
        {
            var avent = _articleQuery.LatestAvents();
            return View(avent);
        }
    }
}
