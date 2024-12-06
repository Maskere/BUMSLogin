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

        private IUserService service { get; set; }
        public GetUserModel(IUserService service){
            this.service = service;
        }

        public IEnumerable<User> Users { get; set; } = new List<User>();

        public void OnGet(){
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                Users = service.GetUser(FilterCriteria);
            }
            else
            {
                Users = service.GetUsers();
            }
        }
    }
}
