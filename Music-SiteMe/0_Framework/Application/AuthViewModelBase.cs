using System.Collections.Generic;

namespace _0_Framework.Application
{
    public class AuthViewModelBase
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }
        public List<int> Permissions { get; set; }
      public string Photo { get; set; }
    }
}