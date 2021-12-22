

using _0_Framework.Domain;
using BlogManagement.Domain.ArticleAgg;
using System.Collections.Generic;

namespace BlogManagement.Domain.ArticleCategoryAgg
{
    public class ArticleCategory : EntityBase
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
       public List<Article> Articles { get; private set; }
        public ArticleCategory()
        {
            Articles = new List<Article>();
            
        }
        public ArticleCategory(string name, string picture, string slug, string keywords)
        {
            Name = name;
            Picture = picture;
            Slug = slug;
            Keywords = keywords;
        }

        public void Edit(string name, string picture, string slug, string keywords)
        {
            Name = name;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            Slug = slug;
            Keywords = keywords;
        }
            
    }
}
