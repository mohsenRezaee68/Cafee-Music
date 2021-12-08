using System.ComponentModel;

namespace MusicManagement.Configuration.Permissions
{
    public static class MusicPermissions
    {
        //Albom
        public const int ListAlboms = 10;
        public const int SearchAlboms = 11;
        public const int CreateAlbom = 12;
        public const int EditAlbom = 13;
        public const int DeleteAlbom = 14;
        public const int NoDeleteAlbom = 15;
        //Tack
        public const int ListTracks = 16;
        public const int SearchTracks = 17;
        public const int CreateTrack = 18;
        public const int EditTrack = 19;
        public const int DeleteTrack = 20;
        public const int NoDeleteTrack = 21;
        //MusicCategory
        public const int ListMusicCategories = 22;
        public const int SearchMusicCategories = 23;
        public const int CreateMusicCategory = 24;
        public const int EditMusicCategory = 25;
    }
}