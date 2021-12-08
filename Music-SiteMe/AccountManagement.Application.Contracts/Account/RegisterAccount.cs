
using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace AccountManagement.Application.Contracts.Account
{
    public class RegisterAccount
    {
     
        public string Fullname { get; set; }
        public IFormFile ProfilePhoto { get; set; } = null;

        public string Username { get; set; }

      
        public string Email { get; set; }

        public string RePassword { get; set; }
        public string Password { get; set; }

        public string Mobile { get; set; }

        public long RoleId { get; set; }

       
        public List<RoleViewModel> Roles { get; set; }
    }
}
