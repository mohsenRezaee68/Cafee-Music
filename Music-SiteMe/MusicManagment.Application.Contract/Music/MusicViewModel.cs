namespace MusicManagement.Application.Contracts.Music
{
    public class MusicViewModel
    {
       // public double UnitPrice { get; set; }
        public long Id { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Singer { get; set; }
        public string Melyat { get; set; }
        public string Sabk { get; set; }
        public string Ferestande { get; set; }
        
        public string Category { get; set; }
        public long CategoryId { get; set; }
        public string CreationDate { get; set; }
      //  public bool IsInStock { get; set; }
    }
}
