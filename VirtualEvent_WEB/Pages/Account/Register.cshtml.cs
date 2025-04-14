using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Registration NewUser { get; set; }

        public static List<Registration> Users = new List<Registration>();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            Users.Add(NewUser);

            // Sign the user in with claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, NewUser.FirstName ?? NewUser.Email),
                new Claim(ClaimTypes.Email, NewUser.Email)
            };

            var identity = new ClaimsIdentity(claims, "Cookies");
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("Cookies", principal);

            return RedirectToPage("/Index");
        }
    }
}
