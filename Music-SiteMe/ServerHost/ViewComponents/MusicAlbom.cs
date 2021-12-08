using _01_LampshadeQuery.Contracts.Music;

using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class MusicAlbom : ViewComponent
    {
        private readonly IMusicQuery _musicQuery;
        public MusicQueryModel Track;
        public MusicAlbom(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

        public IViewComponentResult Invoke()
        {
            var music = _musicQuery.GetAlbomMusics();
            return View(music);
        }
    }
}
