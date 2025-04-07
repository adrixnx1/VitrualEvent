using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace VirtualEvent_WEB.Pages.Account
{
    public class SignINModel : PageModel
    {
        [BindProperty]
    public LoginInputModel LoginUser { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            if (LoginUser.Email == "test@example.com" && LoginUser.Password == "password123")
            {
                return RedirectToPage("/Index"); // go to homepage after login
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
