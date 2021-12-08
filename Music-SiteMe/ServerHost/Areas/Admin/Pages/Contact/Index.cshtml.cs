

using CommentManagement.Application.Contracts.Contact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Contact
{
    public class IndexModel : PageModel
    {
        
        [TempData]
        
        public string Message { get; set; }
        
        public ContactSearchModel SearchModel;
        public List<ContactViewModel> Contacts;
        private readonly IContactApplication _contactApplication;
        
        public IndexModel(IContactApplication contactApplication )
        {
            _contactApplication = contactApplication;
            
        }
        public void OnGet(ContactSearchModel searchModel)
        {
            
            Contacts = _contactApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreateContact();
           
            return Partial("./Create", command);
        }
       // [NeedsPermission(ShopPermissions.CreateProduct)]
        public JsonResult OnPostCreate(CreateContact command)
        {
            var result = _contactApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var product = _contactApplication.GetDetails(id);
          
            return Partial("Edit", product);
        }

       // [NeedsPermission(ShopPermissions.EditProductCategory)]
        public JsonResult OnPostEdit(EditContact command)
        {
            if (ModelState.IsValid)
            {
            }

            var result = _contactApplication.Edit(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetRemove(long id)
        {
            var result = _contactApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetRestore(long id)
        {
            var result = _contactApplication.Restore(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
      
    }
}