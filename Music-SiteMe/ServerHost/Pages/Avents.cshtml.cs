using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class AventsModel : PageModel
    {
        private readonly IArticleQuery _articleQuery;
        public string values = null;
        public List<ArticleQueryModel> Avent;
        public List< ArticleQueryModel> arive;
        public BlogAventViowModel avent;
        public AventsModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(string value, int pageId = 1)
        {
            values= value;
             arive = _articleQuery.LatestAventAlls();
            Avent = _articleQuery.SearchAvents(value);
            avent = _articleQuery.Avents(pageId);
        }
    }
}
