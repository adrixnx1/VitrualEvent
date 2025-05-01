using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model; // ✅ Import your Registration model

namespace VirtualEvent_WEB.Pages.Account
{
    public class ConfirmEmailModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Email { get; set; }

        public string Message { get; set; }

        public IActionResult OnGet()
        {
            if (string.IsNullOrEmpty(Email))
            {
                Message = "Email is missing or invalid.";
                return Page();
            }

            // ✅ Lookup user by email from in-memory list
            var user = RegisterModel.Users.FirstOrDefault(u => u.Email == Email);

            if (user == null)
            {
                Message = "No user found with that email.";
                return Page();
            }

            // ✅ Confirm the user's email
            user.IsEmailConfirmed = true;

            Message = $"Email for {user.Email} has been successfully confirmed.";
            return Page();
        }
    }
}



