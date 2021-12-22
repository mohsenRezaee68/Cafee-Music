
using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class TrackMenal : ViewComponent
    {
        private readonly IMusicQuery _musicQuery;
       
        public TrackMenal(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

        public IViewComponentResult Invoke()
        {
          var  menal = _musicQuery.GetMusicmenallDetails();
           
            return View(menal);
           
        }
    }
}
