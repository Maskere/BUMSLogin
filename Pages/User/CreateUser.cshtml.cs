using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUMS{
    public class CreateUserModel : PageModel{
        [BindProperty]
        public User User { get; set; }

        IUserService service;
        public CreateUserModel(IUserService service){
            this.service = service;
        }

        public IActionResult OnGet(){
            return Page();
        }

        public IActionResult OnPost(int id){
            if(!ModelState.IsValid){
                return Page();
            }
            else{
                User.CreatedAt = DateTime.Now;
                User.CreatedBy = id;
                service.AddUser(User);
            }            
            return RedirectToPage("GetUser");
        }      
    }
}
