using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BUMS{
    public class CreateGroupModel : PageModel{
        [BindProperty]
        public Group Group { get; set; }

        public SelectList? selectListAccess {get;set;}

        private IGroupService service;

        public CreateGroupModel(IGroupService service){
            this.service = service;
        }        

        public IActionResult OnPost(){
            if (!ModelState.IsValid){
                return Page();
            }
            else{
                Group.CreatedAt = DateTime.Now;
                Group.CreatedBy = 1;
                service.AddGroup(Group);
            }
            return RedirectToPage("GetGroup");
        }

        public IActionResult OnGet(){
            return Page();
        }
    }
}
