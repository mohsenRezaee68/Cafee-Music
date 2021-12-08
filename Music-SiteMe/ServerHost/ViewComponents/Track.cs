
using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class Track : ViewComponent
    {
        private readonly IMusicQuery _musicQuery;

        public Track(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

        public IViewComponentResult Invoke()
        {
            var Afg = _musicQuery.GetMusicDetails();
           
            return View(Afg );
           
        }
    }
}
