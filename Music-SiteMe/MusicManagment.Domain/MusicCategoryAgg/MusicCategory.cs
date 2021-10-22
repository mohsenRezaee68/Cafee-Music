
using _0_Framework.Domain;
using MusicManagement.Domain.MusicAgg;
using System.Collections.Generic;

namespace MusicManagement.Domain.MusicCategoryAgg
{
    public class MusicCategory : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string Slug { get; private set; }
       public List<Music> Musics { get; private set; }
        public List<MusicCategory> MusicCatgorys { get; private set; }
        public MusicCategory()
        {
            Musics = new List<Music>();
       }

        public MusicCategory(string name, string description, string picture,
            string pictureAlt, string pictureTitle, string keywords, string metaDescription,
            string slug)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
        }

        public void Edit(string name, string description, string picture,
            string pictureAlt, string pictureTitle, string keywords, string metaDescription,
            string slug)
        {
            Name = name;
            Description = description;

           if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
        }

       
    }
}
