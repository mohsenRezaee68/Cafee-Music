using _0_Framework.Domain;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using _01_LampshadeQuery.Contracts.Account;


namespace ServiceHost.Pages
{

    public class AccountLogupModel : PageModel
    {


        public long R { get; set; }
        public string RegisterMessage = null;
        private readonly IAccountApplication _accountApplication;
       
      
        public AccountLogupModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }
       
        public void OnGet(RegisterAccount command)
        {
            
            if (command.Fullname != null)
            {
                if (command.Password != command.RePassword)
                    RegisterMessage = "کلمه عبور با تکرار برابر نسیت!";
                else
                    RegisterMessage = "امکان ثبت رکورد تکراری وجود ندارد";
            }
           
        }
      
        public IActionResult OnPostRegister(RegisterAccount command)
        {


            var result = _accountApplication.Register(command);
            if (result.IsSuccedded) {
                 return RedirectToPage("/AccountLogin");
            }
           
            
            return RedirectToPage("/AccountLogup", "OnGet", command);
           
        }

    }


        
}
