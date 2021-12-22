using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace CommentManagement.Configuration.Permissions
{
    public class CommentPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Comment", new List<PermissionDto>
                    {
                        
                        new PermissionDto(CommentPermissions.SearchComments, "Search"),
                         new PermissionDto(CommentPermissions.DeleteComment, "Cancel"),
                        new PermissionDto(CommentPermissions.RestorComment, "Confirm"),
                    }
                }
            };
        }
    }
}