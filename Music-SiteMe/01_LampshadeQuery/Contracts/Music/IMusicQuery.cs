using AccountManagement.Application.Contracts.Tak;
using System.Collections.Generic;


namespace _01_LampshadeQuery.Contracts.Music
{
    public interface IMusicQuery
    {
        MusicQueryModel GetAlbomDetails(long id);
        List<MusicQueryModel> GetAlbomMusics();
        
        MohsenViowModel mohsenViowModel(int pageId = 1);
        takViewforadmin AllMusicTak(int pageId = 1);
        takViewforadmin MazhabiTak(int pageId = 1);
        List<MusicQueryModel> SearchAlbom(string value);
        List<MusicQueryModel> SearchTrack(string value);
        List<MusicQueryModel> ArshivMusic();
        List<MusicQueryModel> ArshivIrani();
        List<MusicQueryModel> ArshivAfg();
        List<MusicQueryModel> ArshivMenal();
        List<MusicQueryModel> GetAllTrackss();
        List<MusicQueryModel> GetMusicDetails();
        List<MusicQueryModel> GetMusicmenallDetails();
        List<MusicQueryModel> GetMusicmazhabiDetails();
        List<MusicQueryModel> GetAllTracksMazhabi();
        List<MusicQueryModel> SearchMazhabi(string value);
        List<MusicQueryModel> GetLatestArrivals();
    }
}
