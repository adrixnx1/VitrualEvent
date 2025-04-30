using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace VirtualEvent_WEB.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnPostAsync()
        {
            // Sign the user out and remove the cookie
            await HttpContext.SignOutAsync("Cookies");

            // Redirect to the login page
            return RedirectToPage("/Account/SignIN");
        }
    }
}
