using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace SlideManagement.Configuration.Permissions
{
    public class SlidePermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Slider", new List<PermissionDto>
                    {
                        new PermissionDto(SlidePermissions.List, "GetList"),
                        new PermissionDto(SlidePermissions.Creat, "Create"),
                        new PermissionDto(SlidePermissions.Edite, "Edit"),
                        new PermissionDto(SlidePermissions.Remove, "Remove"),
                        new PermissionDto(SlidePermissions.Restor, "Restore"),
                    }
                }
            };
        }
    }
}