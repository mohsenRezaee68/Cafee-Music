using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace MusicManagement.Configuration.Permissions
{
    public class MusicPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "MusicCategory", new List<PermissionDto>
                    {
                        new PermissionDto(MusicPermissions.CreatCategory, "Create"),
                        new PermissionDto(MusicPermissions.EditeCategory, "Edit"),
                        new PermissionDto(MusicPermissions.ListCategory, "GetMusicCategories"),
                        new PermissionDto(MusicPermissions.SerchCategory, "Search"),
                       
                    }
                },
                 {
                    "TrackMusic", new List<PermissionDto>
                    {
                        new PermissionDto(MusicPermissions.CreatTrack, "Create"),
                        new PermissionDto(MusicPermissions.EditeTrack, "Edit"),
                        new PermissionDto(MusicPermissions.RemoveTrack, "Remove"),
                        new PermissionDto(MusicPermissions.RestorTrack, "Restore"),
                         new PermissionDto(MusicPermissions.SerchTrack, "Search"),
                        
                    }
                },
                {
                    "Alboms", new List<PermissionDto>
                    {
                        new PermissionDto(MusicPermissions.CreatAlbom, "Create"),
                        new PermissionDto(MusicPermissions.EditeAlbom, "Edit"),
                        new PermissionDto(MusicPermissions.RemoveAlbom, "Remove"),
                        new PermissionDto(MusicPermissions.RestorAlbom, "Restore"),
                        new PermissionDto(MusicPermissions.SearchAlbom, "Search"),
                    }
                },{
                    "TrackTakAhang", new List<PermissionDto>
                    {
                        new PermissionDto(MusicPermissions.CreatTakAhang, "Create"),
                        new PermissionDto(MusicPermissions.EditTakAhang, "Edit"),
                        new PermissionDto(MusicPermissions.RemovTakAhang, "Remove"),
                        new PermissionDto(MusicPermissions.RestorTakAhang, "Restore"),
                         new PermissionDto(MusicPermissions.SerchTakAhang, "Search"),

                    }
                },
            };
        }
    }
}