
using _0_Framework.Domain;

using MusicManagement.Domain.MusicCategoryAgg;
using MusicManagement.Domain.MusicTrackAgg;
using System.Collections.Generic;

namespace MusicManagement.Domain.MusicAgg
{
    public class Music : EntityBase
    {


        public string Name { get; private set; }
        public string Dawnlod { get; private set; }
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
        public string Trak { get; set; }
        public bool IsRemoved { get; private set; }
        public MusicCategory Category { get; private set; }
         public List<MusicTrack> MusicTracks { get; private set; }
   
        public Music(string name,string dawnlod ,string singer,
             string melyat, string sabk,string ferestande, string shortDescription,
             string description, string picture, string pictureAlt,
             string pictureTitle, long categoryId, string slug,
             string keywords, string metaDescription)
        {
            Name = name;
            Dawnlod = dawnlod;
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
            IsRemoved = false;
        }


        public void Edite(string name, string singer,
           string melyat, string sabk,string ferestande ,string shortDescription,
           string description, string picture, string pictureAlt,
           string pictureTitle, long categoryId, string slug,
           string keywords, string metaDescription)
        {
            Name = name;
           
            Singer = singer;
            Melyat = melyat;
            Sabk = sabk;
            Ferestande = ferestande;
            ShortDescription = shortDescription;
            Description = description;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CategoryId = categoryId;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
        }



        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }


        //  public void InStock()
        //  {
        //      IsInStock = true;
        //  }
        //  public void NotIdstock()
        //  {
        //      IsInStock = false;
        //  }
    }
}
