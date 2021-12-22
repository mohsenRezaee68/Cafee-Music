

using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SlideManagement.Configuration.Permissions;
using SliderManagement.Application.Contracts.Slide;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Sliders
{
    [Authorize(Roles = "1 , 2")]
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<SlideViewModel> Slides;

        private readonly ISlideApplication _slideApplication;

        public IndexModel(ISlideApplication slideApplication)
        {
            _slideApplication = slideApplication;
        }
        [NeedsPermission(SlidePermissions.List)]
        public void OnGet()
        {
            Slides = _slideApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateSlide();
            return Partial("./Create", command);
        }
        [NeedsPermission(SlidePermissions.Creat)]
        public JsonResult OnPostCreate(CreateSlide command)
        {
            var result = _slideApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _slideApplication.GetDetails(id);
            return Partial("Edit", slide);
        }
        [NeedsPermission(SlidePermissions.Edite)]
        public JsonResult OnPostEdit(EditSlide command)
        {
            var result = _slideApplication.Edit(command);
            return new JsonResult(result);
        }
        [NeedsPermission(SlidePermissions.Remove)]
        public IActionResult OnGetRemove(long id)
        {
            var result = _slideApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
        [NeedsPermission(SlidePermissions.Restor)]
        public IActionResult OnGetRestore(long id)
        {
            var result = _slideApplication.Restore(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
