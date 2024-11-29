using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BUMS.Models;
using System;


namespace BUMS
{
    public class CreateUserModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        IUserService service;
        public CreateUserModel(IUserService service)
        {
            this.service = service;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) //kig på denne
            {
                return Page();
            }
            service.AddUser(user);
            return RedirectToPage("GetUser");
        }
      
    }
}
