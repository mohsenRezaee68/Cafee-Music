using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Account
{
    public class AccountQueryModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string Rol { get; set; }
        public long RolId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pass { get; set; }
        public List<UserMusicQueryModel> Tracks { get; set; }
    }
}
