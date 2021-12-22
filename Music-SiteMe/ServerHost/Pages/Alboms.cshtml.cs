using _0_Framework.Infrastructure;
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
        public MohsenViowModel Albooms;
        public string values = null;
       
        public AlbomsModel(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

     

        public void OnGet(string value , int pageId = 1)
        {
            values = value;
          
           
            Albooms = _musicQuery.mohsenViowModel(pageId);
        }
       
    }
}
