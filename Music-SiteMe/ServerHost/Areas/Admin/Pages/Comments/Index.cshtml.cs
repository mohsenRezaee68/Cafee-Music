using _0_Framework.Infrastructure;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Comments
{
    [Authorize(Roles = "1 , 2")]
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<CommentViewModel> Comments;
       
        public CommentSearchModel SearchModel;
        private readonly ICommentApplication _commentApplication;

        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }
        [NeedsPermission(CommentPermissions.SearchComments)]
        public void OnGet(CommentSearchModel searchModel)
        {
            Comments = _commentApplication.Search(searchModel);
            

        }
        [NeedsPermission(CommentPermissions.DeleteComment)]
        public IActionResult OnGetCancel(long id)
        {
            var result = _commentApplication.Cancel(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(CommentPermissions.RestorComment)]
        public IActionResult OnGetConfirm(long id)
        {
            var result = _commentApplication.Confirm(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
