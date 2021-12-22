
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
            var afg = _musicQuery.GetMusicDetails();
           
            return View(afg);
           
        }
    }
}
