
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Tak;
using AccountManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Accounts.Tak
{
    [Authorize(Roles = "1 , 2")]
    public class IndexModel : PageModel
    {
        
        [TempData]
        
        public string Message { get; set; }
        
        public TakSearchModel SearchModel;
        public List<TakViewModel> Taks;
        private readonly ITakApplication _takApplication;
      
        public IndexModel(ITakApplication takApplication )
        {
            _takApplication = takApplication;
           
        }
        [NeedsPermission(AccountPermissions.Search)]
        public void OnGet(TakSearchModel searchModel)
        {
           
            Taks = _takApplication.Search(searchModel);
        }
        
        public IActionResult OnGetEdit(long id)
        {
            var product = _takApplication.GetDetails(id);
           
            return Partial("Edit", product);
        }

       [NeedsPermission(AccountPermissions.Edit)]
        public JsonResult OnPostEdit(EditTak command)
        {
            if (ModelState.IsValid)
            {
            }

            var result = _takApplication.Edit(command);
            return new JsonResult(result);
        }
        [NeedsPermission(AccountPermissions.Cancel)]
        public IActionResult OnGetCancel(long id)
        {
            var result = _takApplication.Cancel(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(AccountPermissions.Confirm)]
        public IActionResult OnGetConfirm(long id)
        {
            var result = _takApplication.Confirm(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        // public IActionResult onGetNotInStock(long id)
        // {
        //    var result = _productApplication.NotInStock(id);
        //     if (result.IsSuccedded)
        //         return RedirectToPage("./Index");
        //     Message = result.Message;
        //     return RedirectToPage("./Index");
        // }
        // public IActionResult onGetIsInStock(long id)
        // {
        //  var result = _productApplication.IsStock(id);
        //     if (result.IsSuccedded)
        //         return RedirectToPage("./Index");
        //     Message = result.Message;
        //     return RedirectToPage("./Index");
        // }
    }
}