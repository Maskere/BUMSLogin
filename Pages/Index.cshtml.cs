using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace BUMS.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public bool IsAdmin => HttpContext.User.HasClaim("IsAdmin", bool.TrueString);
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
