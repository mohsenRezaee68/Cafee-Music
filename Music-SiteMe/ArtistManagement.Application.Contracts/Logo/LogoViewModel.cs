namespace ArtistManagement.Application.Contracts.Logo
{
    public class LogoViewModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string NameSite { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}