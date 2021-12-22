using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class MusicsModel : PageModel
    {
        private readonly IMusicQuery _musicQuery;
        public MusicQueryModel musics;
        public takViewforadmin music;
        public List<MusicQueryModel> MusicsTak;
        public string values = null;
        public MusicsModel(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

        public void OnGet(string value, int pageId = 1)
        {
            values = value;
            music = _musicQuery.AllMusicTak(pageId);
            MusicsTak = _musicQuery.SearchTrack(value);
        }
    }
}
