using _01_LampshadeQuery.Contracts.Account;


using Microsoft.AspNetCore.Mvc;


namespace ServiceHost.ViewComponents
{
    public class UserMusic : ViewComponent
    {
        private readonly IAccountQuery _accountQuery;
      
        public UserMusic(IAccountQuery accountQuery)
        {
            _accountQuery = accountQuery;
        }

        public IViewComponentResult Invoke()
        {
            var music = _accountQuery.UserMusic();
            return View(music);
        }
    }
}
