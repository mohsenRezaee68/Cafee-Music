namespace MusicManagement.Application.Contracts.MusicCategory
{
    public class MusicCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public long MusicsCount { get; set; }
    }
}
