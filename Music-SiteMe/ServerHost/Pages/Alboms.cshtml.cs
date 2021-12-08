using _01_LampshadeQuery.Contracts.Music;

using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class AlbomsModel : PageModel
    {
        private readonly IMusicQuery _musicQuery;
        public List<MusicQueryModel> MusicsAlbom;
        public List<MusicQueryModel> music;
        public string values = null;
        public AlbomsModel(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

     

        public void OnGet(string value)
        {
            values = value;
            music = _musicQuery.GetAllAlbomMusics();
            MusicsAlbom = _musicQuery.SearchAlbom(value);
        }
       
    }
}
