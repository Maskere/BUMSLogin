using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUMS{
    public class GetUserGroupModel : PageModel{
        [BindProperty]
        public User User {get;set;}
        [BindProperty]
        public Group Group {get;set;}
        [BindProperty]
        public Access Access {get;set;}
        [BindProperty]
        public IEnumerable<UserGroup> userGroups {get;set;}

        private IUserGroupService service;
        public GetUserGroupModel(IUserGroupService service){
            this.service = service;
        }
        public IActionResult OnGet(){
            userGroups = service.GetUserGroups();
            return Page();
        }
    }
}
