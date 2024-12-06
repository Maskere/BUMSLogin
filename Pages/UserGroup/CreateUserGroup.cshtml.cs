using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace BUMS{
    public class CreateUserGroupModel : PageModel{
        [BindProperty]
        public UserGroup UserGroup {get;set;}

        IUserGroupService service;
        public CreateUserGroupModel(IUserGroupService service){
            this.service = service;
        }

        public IActionResult OnGet(){
            return Page();
        }
        public IActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            else{
                service.AddUserGroup(UserGroup);
            }
            return RedirectToPage("GetUserGroup");
        }
    }
}
