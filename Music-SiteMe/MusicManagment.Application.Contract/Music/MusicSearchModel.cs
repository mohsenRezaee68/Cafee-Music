namespace MusicManagement.Application.Contracts.Music
{
    public class MusicSearchModel
    {
        public string Name { get; set; }
        public string Singer { get; set; }
        public string Ferestande { get; set; }
        public long MusicId { get; set; }
        public long CategoryId { get; set; }
    }
}
