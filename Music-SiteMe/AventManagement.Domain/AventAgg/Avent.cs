


using _0_Framework.Domain;
using System;

namespace AventManagement.Domain.AventAgg
{
    public class Avent : EntityBase
    {
        public string Title { get; private set; }
        
        public string Toppic { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public DateTime PublishDate { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }

        public Avent(string title, string toppic, string picture, 
            string pictureAlt, string pictureTitle, DateTime publishDate,
            string slug, string keywords, string metaDescription)
        {
            Title = title;
            Toppic = toppic;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            PublishDate = publishDate;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
        }

        public void Edit(string title, string toppic, string picture,
            string pictureAlt, string pictureTitle, DateTime publishDate,
            string slug, string keywords, string metaDescription)
        {
             Title = title;
            Toppic = toppic;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            PublishDate = publishDate;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
        }
    }
}
