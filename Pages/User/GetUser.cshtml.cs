using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUMS{
    [Authorize]
    public class GetUserModel : PageModel{
        public bool IsAdmin => HttpContext.User.HasClaim("IsAdmin", bool.TrueString);

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        public IEnumerable<User> user { get; set; }

        private IUserService userService { get; set; }

        public GetUserModel(IUserService service){
            this.userService = service;
        }

        public IEnumerable<User> Users { get; set; } = new List<User>();

        public void OnGet(){
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                Users = userService.GetUser(FilterCriteria);
            }
            else
            {
                Users = userService.GetUsers();
            }
        }
    }
}
