using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class MusicMazhabiModel : PageModel
    {
        private readonly IMusicQuery _musicQuery;
        public MusicQueryModel musics;
        public List< MusicQueryModel> music;
        public List<MusicQueryModel> MusicsTak;
        public string values = null;
        public MusicMazhabiModel(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

        public void OnGet(string value)
        {
            values = value;
            music = _musicQuery.GetAllTracksMazhabi();
            MusicsTak = _musicQuery.SearchMazhabi(value);
        }
    }
}
