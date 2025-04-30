using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using VirtualEvent_WEB.Model;
using System.Text.Encodings.Web;

namespace VirtualEvent_WEB.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly EmailSender _emailSender;

        public RegisterModel(EmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [BindProperty]
        public Registration NewUser { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;


        public static List<Registration> Users = new List<Registration>();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            // Store user temporarily in memory (you'll replace this with real DB later)
            Users.Add(NewUser);

            // Simulate confirmation token and userId
            var token = Guid.NewGuid().ToString(); // placeholder for real token
            var userId = NewUser.Email; // simulating with email for now

            // ✅ Generate confirmation link using Razor Pages
            var confirmUrl = Url.Page(
                "/Account/ConfirmEmail", // path to the Razor page
                pageHandler: null,
                values: new { userId = userId, token = token },
                protocol: Request.Scheme
            );

            // ✅ Send the confirmation email
            await _emailSender.SendEmailAsync(
                NewUser.Email,
                "Confirm your email for VitrualEvent",
                $"<p>Hi {NewUser.FirstName},</p><p>Please confirm your account by clicking <a href='{HtmlEncoder.Default.Encode(confirmUrl)}'>here</a>.</p>"
            );

            // Show success message and redirect to confirmation notice
            TempData["Message"] = "Registration successful! Please check your email to confirm your account.";
            return RedirectToPage("/Account/Login");
        }

    }
}