namespace MusicManagement.Application.Contracts.Tak
{
    public class TakViewModel
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
    }
}
