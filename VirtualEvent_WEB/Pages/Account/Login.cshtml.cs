using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace VirtualEvent_WEB.Pages.Account
{
    public class SignINModel : PageModel
    {
        [BindProperty]
        public LoginInputModel LoginUser { get; set; }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            // Simulate user lookup from register (replace with actual database query)
            var user = RegisterModel.Users.FirstOrDefault(u =>
                u.Email == LoginUser.Email && u.Password == LoginUser.Password);

            if (user != null)
            {
                // Build claims
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.FirstName ?? user.Email),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim("IsAdmin", user.IsAdmin.ToString())  // Admin flag
                };

                // Create identity and sign in
                var identity = new ClaimsIdentity(claims, "Cookies");
                var principal = new ClaimsPrincipal(identity);

                // Set authentication properties for persistent login
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,  // Keep the user logged in after closing the browser
                    ExpiresUtc = DateTime.UtcNow.AddDays(7)  // Set cookie to expire in 7 days
                };

                await HttpContext.SignInAsync("Cookies", principal, authProperties);

                return RedirectToPage("/Index");  // Redirect to the home page
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }

        public class LoginInputModel
        {
            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invalid email format")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password is required")]
            public string Password { get; set; }
        }
    }
}
