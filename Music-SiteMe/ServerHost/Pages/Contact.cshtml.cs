


using _01_LampshadeQuery.Contracts.Contact;
using CommentManagement.Application.Contracts.Comment;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ContactsModel : PageModel
    {
        private readonly ICommentApplication _commentApplication;
      public ContactQueryModel Contact;
        private readonly IContactQuery _contactQuery;

        public ContactsModel( ICommentApplication commentApplication , IContactQuery contactQuery)
        {
            _contactQuery = contactQuery;
            _commentApplication = commentApplication;
        }
        public void OnGet()
        {
            Contact = _contactQuery.GetContacts();
          
        }


        public IActionResult OnPost(AddComment command)
        {
            command.Type = CommentType.Contact;
            var result = _commentApplication.Add(command);
            return RedirectToPage("/Contacts");
        }
    }
}
