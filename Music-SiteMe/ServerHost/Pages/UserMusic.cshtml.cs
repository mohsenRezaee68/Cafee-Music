
using _01_LampshadeQuery.Contracts.Account;
using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class UserMusicModel : PageModel
    {
        private readonly IAccountQuery _accountQuery;
       
        public takUserViowModel music;
       
        public List<UserMusicQueryModel> MusicsTak;
        public string values = null;
        public UserMusicModel(IAccountQuery accountQuery)
        {
            _accountQuery = accountQuery;
        }

        public void OnGet(string value , int pageId = 1)
        {
            values = value;
            music = _accountQuery.UserMusicTak(pageId);
            MusicsTak = _accountQuery.SearchTrack(value);
            
        }
        
    }
}
