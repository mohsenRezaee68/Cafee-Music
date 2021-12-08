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
                    "Albom", new List<PermissionDto>
                    {
                        new PermissionDto(MusicPermissions.ListAlboms, "ListAlboms"),
                        new PermissionDto(MusicPermissions.SearchAlboms, "SearchAlboms"),
                        new PermissionDto(MusicPermissions.CreateAlbom, "CreateAlbom"),
                        new PermissionDto(MusicPermissions.EditAlbom, "EditAlbom"),
                        new PermissionDto(MusicPermissions.DeleteAlbom, "DeleteAlbom"),
                        new PermissionDto(MusicPermissions.NoDeleteAlbom, "NoDeleteAlbom"),
                    }
                },
                 {
                    "TrackMusic", new List<PermissionDto>
                    {
                        new PermissionDto(MusicPermissions.ListTracks, "ListTracks"),
                        new PermissionDto(MusicPermissions.SearchTracks, "SearchTracks"),
                        new PermissionDto(MusicPermissions.CreateTrack, "CreateTrack"),
                        new PermissionDto(MusicPermissions.EditTrack, "EditTrack"),
                         new PermissionDto(MusicPermissions.DeleteTrack, "DeleteTrack"),
                        new PermissionDto(MusicPermissions.NoDeleteTrack, "NoDeleteTrack"),
                    }
                },
                {
                    "MusicCategory", new List<PermissionDto>
                    {
                        new PermissionDto(MusicPermissions.SearchMusicCategories, "SearchMusicCategories"),
                        new PermissionDto(MusicPermissions.ListMusicCategories, "ListMusicCategories"),
                        new PermissionDto(MusicPermissions.CreateMusicCategory, "CreateMusicCategory"),
                        new PermissionDto(MusicPermissions.EditMusicCategory, "EditMusicCategory"),
                    }
                }
            };
        }
    }
}