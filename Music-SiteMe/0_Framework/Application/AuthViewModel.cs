using System.Collections.Generic;

namespace _0_Framework.Application
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string Role { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        
        public string Email { get; set; }
        public List<int> Permissions { get; set; }
        public string Photo { get; set; }
        public AuthViewModel()
        {
        }

        public AuthViewModel(long id, long roleId, string fullname, string username,
            string email, List<int> permissions , string photo)
        {
            Id = id;
            RoleId = roleId;
            Fullname = fullname;
            Username = username;
            Email = email;
            Permissions = permissions;
            Photo = photo;
        }
    }
}