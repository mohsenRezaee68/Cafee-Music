
using _01_LampshadeQuery.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class UserMusicModel : PageModel
    {
        private readonly IAccountQuery _accountQuery;
       
        public List< UserMusicQueryModel> music;
       
        public List<UserMusicQueryModel> MusicsTak;
        public string values = null;
        public UserMusicModel(IAccountQuery accountQuery)
        {
            _accountQuery = accountQuery;
        }

        public void OnGet(string value , int Adad)
        {
            values = value;
            music = _accountQuery.UserMusic();
            MusicsTak = _accountQuery.SearchTrack(value);
            
        }
        
    }
}
