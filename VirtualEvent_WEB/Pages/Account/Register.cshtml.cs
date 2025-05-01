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

        // ✅ Shared user list for this app
        public static List<Registration> Users = new List<Registration>();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            // Optional: check for duplicate email
            if (Users.Any(u => u.Email == NewUser.Email))
            {
                ModelState.AddModelError(string.Empty, "Email already registered.");
                return Page();
            }

            // Add the user
            Users.Add(NewUser);

            // Make Adriana an admin if her email matches
            if (NewUser.Email == "abarcenas2020@gmail.com")
            {
                NewUser.IsAdmin = true;
            }


            // Create claims for authentication
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, NewUser.FirstName ?? NewUser.Email),
                new Claim(ClaimTypes.Email, NewUser.Email),
                new Claim("IsAdmin", NewUser.IsAdmin.ToString()),
                new Claim("IsEmailConfirmed", NewUser.IsEmailConfirmed.ToString()),
                new Claim("AccountType", NewUser.AccountType ?? "User")
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToPage("/Index");
        }
    }
}
