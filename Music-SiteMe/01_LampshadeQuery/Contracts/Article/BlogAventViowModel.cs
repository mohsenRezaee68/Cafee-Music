using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Music;

using System.Collections.Generic;


namespace _01_LampshadeQuery.Contracts.Music
{
    public class BlogAventViowModel
    {
    
         public List<ArticleQueryModel> avent { get; set; }
        public int CurrentPage { get;  set; }
       
        public int PageCount { get;  set; }
    }

}

