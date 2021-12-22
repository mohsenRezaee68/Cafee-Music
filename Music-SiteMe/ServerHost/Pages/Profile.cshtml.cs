using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Account;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Tak;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace ServiceHost.Pages
{
    public class ProfileModel : PageModel
    {
        public AccountQueryModel music;
        private readonly IAccountQuery _musicQuery;
        private readonly IAuthHelper _authHelper;
        private readonly ITakApplication _takApplication;
        private readonly IAccountApplication _accountApplication;

        [TempData]
        public string Messages { get; set; }
       
        public ProfileModel(IAccountQuery musicQuery , IAuthHelper authHelper, ITakApplication takApplication,
            IAccountApplication accountApplication)
        {
            _musicQuery = musicQuery;
            _authHelper = authHelper;
            _takApplication = takApplication;
            _accountApplication = accountApplication;
        }

       
        public void OnGet()
        {
          
            var currentAccountId = _authHelper.CurrentAccountId();
            if(currentAccountId == 0)
                RedirectToPage("/AccessDenied");
            else { music = _musicQuery.GetAccount(currentAccountId); }
            
           
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateTak();
           
            return Partial("./Create", command);
        }
        public IActionResult OnPostCreate(CreateTak command)
        {
            var result = _takApplication.Create(command);
          
           
              return RedirectToPage("/Profile");
        }
        public IActionResult OnGetEdit(long id)
        {
            var account = _accountApplication.GetDetails(id);
           
            return Partial("Edit", account);
        }
       
        public IActionResult OnPostEdit(EditAccount command)
        {
            var result = _accountApplication.Edit(command);
            
           
            return RedirectToPage("/Profile");
        }

        public IActionResult OnGetChangePassword(long id)
        {
            var command = new ChangePassword { Id = id };
            return Partial("ChangePassword", command);
        }
     
        public IActionResult OnPostChangePassword(ChangePassword command)
        {
            command.RePassword = command.Password;
            var result = _accountApplication.ChangePassword(command);
            if (result.IsSuccedded)
                return RedirectToPage("/Profile");

            return RedirectToPage("/Profile");

        }
    }
}
