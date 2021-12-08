

using _0_Framework.Domain;
using MusicManagement.Domain.MusicCategoryAgg;

namespace MusicManagement.Domain.TakAgg
{
    public class Tak : EntityBase
    {
        public string Name { get; private set; }

        public string Singer { get; private set; }
        public string Melyat { get; private set; }
        public string Sabk { get; private set; }
        public string Ferestande { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public long CategoryId { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string Trak { get; private set; }
        public bool IsRemoved { get; private set; }
        public MusicCategory Category { get; private set; }

        public Tak(string name, string singer, string melyat, string sabk, string ferestande, 
            string shortDescription, string description, string picture, string pictureAlt,
            string pictureTitle, long categoryId, string slug, string keywords, string metaDescription, string trak)
        {
            Name = name;
            Singer = singer;
            Melyat = melyat;
            Sabk = sabk;
            Ferestande = ferestande;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CategoryId = categoryId;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Trak = trak;
            IsRemoved = false;
        }

        public void Edite(string name, string singer, string melyat, string sabk, string ferestande,
            string shortDescription, string description, string picture, string pictureAlt,
            string pictureTitle, long categoryId, string slug, string keywords, string metaDescription, string trak)
        {
            Name = name;
            Singer = singer;
            Melyat = melyat;
            Sabk = sabk;
            Ferestande = ferestande;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CategoryId = categoryId;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Trak = trak;
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
