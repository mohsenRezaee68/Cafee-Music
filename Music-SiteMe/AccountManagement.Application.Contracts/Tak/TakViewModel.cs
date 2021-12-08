namespace AccountManagement.Application.Contracts.Tak
{
    public class TakViewModel
    {
        public long Id { get; set; }
       
        public string NameMusic { get; set; }
        public string Singer { get; set; }
        
        public string Sabk { get; set; }
        public string Rol { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string CreationDate { get; set; }
         public string Trak { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsCanceled { get; set; }
        public string UserAccount { get; set; }
    }
}
