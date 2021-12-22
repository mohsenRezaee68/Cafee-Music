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
                        new PermissionDto(AccountPermissions.ListAccount, "GetAccounts"),
                        new PermissionDto(AccountPermissions.SearchAccounts, "Search"),
                         new PermissionDto(AccountPermissions.EditAccount, "Edit"),
                         new PermissionDto(AccountPermissions.CreateAccount, "CreateArtist"),
                       new PermissionDto(AccountPermissions.ChengePass, "ChangePassword"),
                       
                    }
                }, {
                    "Rol", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListRol, "List"),
                       new PermissionDto(AccountPermissions.EditRol, "Edit"),
                         new PermissionDto(AccountPermissions.CreateRol, "Create"),
                        
                    }
                },  {
                    "musicuser", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.Create, "Create"),
                        new PermissionDto(AccountPermissions.Edit, "Edit"),
                         new PermissionDto(AccountPermissions.Confirm, "Confirm"),
                         new PermissionDto(AccountPermissions.Cancel, "Cancel"),
                         new PermissionDto(AccountPermissions.Search, "Search"),
                       
                    }
                },

            };
        }
    }
}