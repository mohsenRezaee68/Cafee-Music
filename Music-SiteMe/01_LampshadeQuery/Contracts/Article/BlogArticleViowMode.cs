using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Music;

using System.Collections.Generic;


namespace _01_LampshadeQuery.Contracts.Music
{
    public class BlogArticleViowMode
    {
    
         public List<ArticleQueryModel> Articles { get; set; }
        public int CurrentPage { get;  set; }
       
        public int PageCount { get;  set; }
    }

}

