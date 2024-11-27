using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BUMS.Models;

namespace BUMS
{
    public class GetUserModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IEnumerable<User> user { get; set; }
        IUserService userService { get; set; }
        public GetUserModel(IUserService service)
        {
            this.userService = service;
        }
        public IEnumerable<User> Users { get; set; } = new List<User>();
        public void OnGet()
        {
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                Users = userService.GetUser(FilterCriteria);
            }
            else
            {
                Users = userService.GetUser();
            }
        }
    }
}
