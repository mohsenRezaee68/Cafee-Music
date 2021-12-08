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
                        new PermissionDto(CommentPermissions.ListComments, "ListComments"),
                        new PermissionDto(CommentPermissions.SearchComments, "SearchComments"),
                         new PermissionDto(CommentPermissions.DeleteComment, "DeleteComment"),
                        new PermissionDto(CommentPermissions.NoDeleteComment, "NoDeleteComment"),
                    }
                }
            };
        }
    }
}