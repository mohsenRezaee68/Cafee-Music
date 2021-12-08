using _01_LampshadeQuery.Contracts.Music;

using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        public string Value;
        public List<MusicQueryModel> MusicsAlbom;
        public List<MusicQueryModel> Musics;
        private readonly IMusicQuery _musicQuery;

        public SearchModel(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

        public void OnGet(string value)
        {
            Value = value;
            MusicsAlbom = _musicQuery.SearchAlbom(value);
            Musics = _musicQuery.SearchTrack(value);
        }
    }
}
