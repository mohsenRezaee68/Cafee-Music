using _01_LampshadeQuery.Contracts.Comment;
using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Music
{
    public class MusicQueryModel
    {
        public string Name { get;  set; }
         public long Id { get;  set; }
        public string Singer { get;  set; }
        public string Melyat { get;  set; }
        public string Sabk { get;  set; }
        public string Ferestande { get;  set; }
        public string ShortDescription { get;  set; }
        public string Description { get;  set; }
        public string Picture { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public string Laghab { get; set; }
        public long CategoryId { get;  set; }
        public string CategorySlug { get; set; }
        public string Catgory { get; set; }
        public string Slug { get; set; } 
        public string Keywords { get;  set; }
        public string MetaDescription { get;  set; }
        public string Track { get; set; }
        public List<CommentQueryModel> Comments { get; set; }
        public List<MusicTrackQueryModel> Tracks { get; set; }
        public string Dawnlod { get; internal set; }
    }

}