using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Account
{
    public class ConfirmEmailModel : PageModel
    {
        public string Message { get; set; }

        public IActionResult OnGet(string userId, string token)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                Message = "Invalid confirmation link.";
                return Page();
            }

            // Find the user in the in-memory list
            var user = RegisterModel.Users.FirstOrDefault(u => u.Email == userId);
            if (user == null)
            {
                Message = "User not found.";
                return Page();
            }

            // Mark the user's email as confirmed
            user.IsEmailConfirmed = true;

            Message = "Email confirmed! You may now log in.";
            return Page();
        }
    }
}


