using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using VirtualEvent_WEB.Pages.Account;

namespace VirtualEvent_WEB.Pages.Admin
{
    public class AdminModel : PageModel
    {
        public List<Registration> AllUsers { get; set; }

        public IActionResult OnGet()
        {
            // Only allow access if logged in as Admin
            if (!User.HasClaim("IsAdmin", "True"))
            {
                return RedirectToPage("/Account/Login");
            }

            AllUsers = RegisterModel.Users;
            return Page();
        }

        public IActionResult OnPostDelete(string email)
        {
            var user = RegisterModel.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                RegisterModel.Users.Remove(user);
            }

            return RedirectToPage();
        }
    }
}

