using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace ArtistManagement.Configuration.Permissions
{
    public class ArtistPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Artist", new List<PermissionDto>
                    {
                        new PermissionDto(ArtistPermissions.ListArtist, "GetList"),
                        new PermissionDto(ArtistPermissions.SearchArtists, "Search"),
                         new PermissionDto(ArtistPermissions.EditArtist, "Edit"),
                         new PermissionDto(ArtistPermissions.CreateArtist, "Create"),
                         new PermissionDto(ArtistPermissions.DeleteArtist, "Remove"),
                        new PermissionDto(ArtistPermissions.RestorArtist, "Restore"),
                    }
                },
                  
            };
        }
    }
}