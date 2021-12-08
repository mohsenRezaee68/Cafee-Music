using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class MusicsModel : PageModel
    {
        private readonly IMusicQuery _musicQuery;
        public MusicQueryModel musics;
        public List< MusicQueryModel> music;
        public List<MusicQueryModel> MusicsTak;
        public string values = null;
        public MusicsModel(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

        public void OnGet(string value)
        {
            values = value;
            music = _musicQuery.GetAllTrackss();
            MusicsTak = _musicQuery.SearchTrack(value);
        }
    }
}
