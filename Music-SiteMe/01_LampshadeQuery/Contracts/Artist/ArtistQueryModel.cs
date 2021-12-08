using _01_LampshadeQuery.Contracts.Comment;

using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Artist
{
    public class ArtistQueryModel
    {
        public long Id { get; set; }
        public string Picture { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public string Laghab { get;  set; }
        public string Text { get;  set; }
        public string Name { get;  set; }
        public string ShertText { get;  set; }
        public string Slug { get;  set; }
        public string Keywords { get;  set; }
        public string MetaDescription { get;  set; }
        public List<string> KeywordList { get; set; }
        
        public List<CommentQueryModel> Comments { get; set; }
    }
}
