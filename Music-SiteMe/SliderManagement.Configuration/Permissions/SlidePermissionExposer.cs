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
                        new PermissionDto(SlidePermissions.ListSlides, "ListSlides"),
                        new PermissionDto(SlidePermissions.SearchSlides, "SearchSlides"),
                        new PermissionDto(SlidePermissions.CreateSlide, "CreateSlide"),
                        new PermissionDto(SlidePermissions.EditSlide, "EditSlide"),
                        new PermissionDto(SlidePermissions.DeleteSlide, "DeleteSlide"),
                        new PermissionDto(SlidePermissions.NoDeleteSlide, "NoDeleteSlide"),
                    }
                }
            };
        }
    }
}