using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Music;
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
        public BlogArticleViowMode article;
        public ArticlsModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(string value, int pageId = 1)
        {
            values = value;
           // Article = _articleQuery.LatestArticleAlls();
            ArticleSerch = _articleQuery.SearchArticles(value);
            article = _articleQuery.Articles(pageId);
        }
    }
}
