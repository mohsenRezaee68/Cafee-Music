using _0_Framework.Domain;
using AccountManagement.Domain.RoleAgg;
using AccountManagement.Domain.TakAgg;
using System;
using System.Collections.Generic;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public long RoleId { get; private set; }
        public bool IsConfirmed { get; private set; }
        public bool IsCanceled { get; private set; }
        public Role Role { get; private set; }
        public string ProfilePhoto { get; private set; }=null;
        public List<Tak> Tracks { get; private set; }
        
        public Account(string fullname, string username,string email, string password, string mobile,
            long roleId, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Email = email;
            Password = password;
            Mobile = mobile;
            RoleId = roleId;

            if (roleId == 0)
                RoleId = 3;
            
            ProfilePhoto = profilePhoto;
           
        }

        public void Edit(string fullname, string username,string email, string mobile,
            long roleId, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Email = email;
            Mobile = mobile;
            RoleId = roleId;

            if (!string.IsNullOrWhiteSpace(profilePhoto))
            ProfilePhoto = profilePhoto;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void Confirm()
        {
            IsConfirmed = true;
        }

        public void Cancel()
        {
            IsCanceled = false;
        }
    }
}
