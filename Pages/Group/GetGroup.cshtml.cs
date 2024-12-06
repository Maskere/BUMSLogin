using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace BUMS{
    [Authorize]
    public class GetGroupModel : PageModel{
        public bool IsAdmin => HttpContext.User.HasClaim("IsAdmin", bool.TrueString);

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public Group Group { get; set; }
        private IGroupService context;

        public GetGroupModel(IGroupService service){
            context = service;
        }

        public IActionResult OnGet(){
            if(!IsAdmin) return Forbid();
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                Groups = context.FilterGroupByName(FilterCriteria);
            }
            else
            {
                Groups = context.GetGroup();
            }                       
            return Page();
        }
    }
}
