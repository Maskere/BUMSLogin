using BUMS.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUMS.Pages.Group
{
    public class DeleteGroupModel : PageModel
    {
        [BindProperty]
        public Models.Group group { get; set; }

        IGroupService service;

        public DeleteGroupModel(IGroupService service)
        {
            this.service = service;
        }
        public void OnGet(int id)
        {
            group = service.GetGroupById(id);
        }
        public IActionResult OnPost()
        {
            service.DeleteGroup(group);
            return RedirectToPage("GetGroup");
        }
    }
}