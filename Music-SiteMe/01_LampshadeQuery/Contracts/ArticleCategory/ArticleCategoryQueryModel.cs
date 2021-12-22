using _01_LampshadeQuery.Contracts.Article;

using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.ArticleCategory
{
    public class ArticleCategoryQueryModel
    {
        public string Name { get; set; }
        public string Picture { get; set; }
       public string Slug { get; set; }
        public string Keywords { get; set; }
        public List<string> KeywordList { get; set; }
     
        public long ArticlesCount { get; set; }
       
        public List<ArticleQueryModel> Articles { get; set; }
    }
}
