using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace BUMS{
    [Authorize]
    public class GetUserGroupModel : PageModel{
        public bool IsAdmin => HttpContext.User.HasClaim("IsAdmin", bool.TrueString);

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
            if(!IsAdmin) return Forbid();
            userGroups = service.GetUserGroups();
            return Page();
        }
    }
}
