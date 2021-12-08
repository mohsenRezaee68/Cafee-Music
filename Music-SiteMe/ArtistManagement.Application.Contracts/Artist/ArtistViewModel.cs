namespace ArtistManagement.Application.Contracts.Artist
{
    public class ArtistViewModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string Text { get; set; }
        public string ShertText { get; set; }
        public bool IsRemoved { get; set; }
        public string Name { get; set; }
        public string Laghab { get; set; }
       public string CreationDate{get;set;}
        public string Slug { get; set; }
        public string Keywords { get;  set; }
        public string MetaDescription { get;  set; }
    }
}