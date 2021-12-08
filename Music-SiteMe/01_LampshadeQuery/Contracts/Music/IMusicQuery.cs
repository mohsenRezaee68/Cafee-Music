using System.Collections.Generic;


namespace _01_LampshadeQuery.Contracts.Music
{
    public interface IMusicQuery
    {
        MusicQueryModel GetAlbomDetails(long id);
        List<MusicQueryModel> GetAlbomMusics();
        List<MusicQueryModel> GetAllAlbomMusics();

        List<MusicQueryModel> SearchAlbom(string value);
        List<MusicQueryModel> SearchTrack(string value);
        List<MusicQueryModel> ArshivMusic();
        List<MusicQueryModel> ArshivIrani();
        List<MusicQueryModel> ArshivAfg();
        List<MusicQueryModel> ArshivMenal();
        List<MusicQueryModel> GetAllTrackss();
        List<MusicQueryModel> GetMusicDetails();
        List<MusicQueryModel> GetAllTracksMazhabi();
        List<MusicQueryModel> SearchMazhabi(string value);
        List<MusicQueryModel> GetLatestArrivals();
    }
}
