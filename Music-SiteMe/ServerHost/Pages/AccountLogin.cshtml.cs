
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ServiceHost.Pages
{
    public class AccountLoginModel : PageModel
    {
        [TempData]
        public string LoginMessage { get; set; }

        [TempData]
        public string RegisterMessage { get; set; }

       
        private readonly IAccountApplication _accountApplication;
        
        public AccountLoginModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication; 
        }

        public void OnGet()
        {
           
        }

        public IActionResult OnPostLogin(Login command)
        {
            var result = _accountApplication.Login(command);
            if (result.IsSuccedded)
                return RedirectToPage("/Index");

            LoginMessage = result.Message;
            return RedirectToPage("/AccountLogin");
        }

        public IActionResult OnGetLogout()
        {
            _accountApplication.Logout();
            return RedirectToPage("/Index");
        }

       
    }
}
