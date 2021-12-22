
using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class TrackMazhabi : ViewComponent
    {
        private readonly IMusicQuery _musicQuery;
       
        public TrackMazhabi(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

        public IViewComponentResult Invoke()
        {
          var  mazhabi = _musicQuery.GetMusicmazhabiDetails();
           
            return View(mazhabi);
           
        }
    }
}
