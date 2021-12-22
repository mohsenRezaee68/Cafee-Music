using _0_Framework.Domain;
using BlogManagement.Domain.ArticleCategoryAgg;


namespace BlogManagement.Domain.ArticleAgg
{
    public class Article : EntityBase
    {
        public string Mozo { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
       
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; } 
       
        public long CategoryId { get; private set; }
        public ArticleCategory Category { get; private set; }
        public bool IsRemoved { get; private set; }

        public Article(string mozo, string shortDescription, string description, string picture,
            string pictureAlt, string pictureTitle, string slug, string keywords, string metaDescription, long categoryId)
        {
            Mozo = mozo;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CategoryId = categoryId;
            IsRemoved = false;
        }

        public void Edit(string mozo, string shortDescription, string description, string picture,
            string pictureAlt, string pictureTitle, string slug, string keywords, string metaDescription, long categoryId)
        {
            Mozo = mozo;
            ShortDescription = shortDescription;
            Description = description;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CategoryId = categoryId;
        }
            
         
        public void Remove() 
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
