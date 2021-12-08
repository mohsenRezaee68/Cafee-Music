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
                        new PermissionDto(ArtistPermissions.ListArtist, "ListArtist"),
                        new PermissionDto(ArtistPermissions.SearchArtists, "SearchArtists"),
                         new PermissionDto(ArtistPermissions.EditArtist, "EditArtist"),
                         new PermissionDto(ArtistPermissions.CreateArtist, "CreateArtist"),
                         new PermissionDto(ArtistPermissions.DeleteArtist, "DeleteArtist"),
                        new PermissionDto(ArtistPermissions.NoDeleteArtist, "NoDeleteArtist"),
                    }
                },
                  
            };
        }
    }
}