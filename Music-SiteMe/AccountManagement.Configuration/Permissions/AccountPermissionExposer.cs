using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace AccountManagement.Configuration.Permissions
{
    public class AccountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Account", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListAccount, "ListAccount"),
                        new PermissionDto(AccountPermissions.SearchAccounts, "SearchAccounts"),
                         new PermissionDto(AccountPermissions.EditAccount, "EditAccount"),
                         new PermissionDto(AccountPermissions.CreateAccount, "CreateArtist"),
                         new PermissionDto(AccountPermissions.DeleteAccount, "DeleteAccount"),
                        new PermissionDto(AccountPermissions.NoDeleteAccount, "NoDeleteAccount"),
                        new PermissionDto(AccountPermissions.ChengePass, "ChengePass"),
                        new PermissionDto(AccountPermissions.Ok, "Ok"),
                        new PermissionDto(AccountPermissions.NoOk, "NoOk"),
                    }
                }, {
                    "Rol", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListRol, "ListRol"),
                        new PermissionDto(AccountPermissions.SearchRol, "SearchRol"),
                         new PermissionDto(AccountPermissions.EditRol, "EditRol"),
                         new PermissionDto(AccountPermissions.CreateRol, "CreateRol"),
                        
                    }
                },

            };
        }
    }
}