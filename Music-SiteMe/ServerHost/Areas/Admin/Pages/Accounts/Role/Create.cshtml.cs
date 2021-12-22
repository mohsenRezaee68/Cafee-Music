using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Role
{
    [Authorize(Roles = "1 , 2")]
    public class CreateModel : PageModel
    {
        public CreateRole Command;
        private readonly IRoleApplication _roleApplication;

        public CreateModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }

        public void OnGet()
        {
        }
        [NeedsPermission(AccountPermissions.CreateRol)]
        public IActionResult OnPost(CreateRole command)
        {
            var result = _roleApplication.Create(command);
            return RedirectToPage("Index");
        }
    }
}