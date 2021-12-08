using _01_LampshadeQuery.Contracts.Article;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class ArticlsModel : PageModel
    {
        private readonly IArticleQuery _articleQuery;
        public string values = null;
        public List<ArticleQueryModel> Article;
        public List<ArticleQueryModel> ArticleSerch;
        public ArticlsModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(string value)
        {
            values = value;
            Article = _articleQuery.LatestArticleAlls();
            ArticleSerch = _articleQuery.SearchArticles(value);
        }
    }
}
