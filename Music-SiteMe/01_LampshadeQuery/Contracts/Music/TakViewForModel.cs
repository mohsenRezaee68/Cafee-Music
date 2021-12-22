namespace _01_LampshadeQuery.Contracts.Music
{
    public class TakViewForModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string NameMusic { get; set; }
        public string Singer { get; set; }
        public string Melyat { get; set; }
        public string Sabk { get; set; }
        public string Ferestande { get; set; }
        public long MusicId { get; set; }
        public string Category { get; set; }
        public long CategoryId { get; set; }
        public string CreationDate { get; set; }
        public bool IsRemoved { get; set; }
        public string Trak { get; set; }
        public object CategorySlug { get;  set; }
        public object PictureAlt { get;  set; }
        public object PictureTitle { get;  set; }
        public object ShortDescription { get;  set; }
        public object Slug { get;  set; }
    }
}
