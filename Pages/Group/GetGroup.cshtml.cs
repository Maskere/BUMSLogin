using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUMS{
    public class GetGroupModel : PageModel{
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public Group Group { get; set; }
        private IGroupService context;

        public GetGroupModel(IGroupService service){
            context = service;
        }

        public void OnGet(){
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                Groups = context.FilterGroupByName(FilterCriteria);
            }
            else
            {
                Groups = context.GetGroup();
            }                       
        }
    }
}
