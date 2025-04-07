using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Account
{
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public Registration User { get; set; }
        public void OnGet()
        {
            User = new Registration
            {
                FirstName = "Adriana",
                LastName = "Barcenas",
                Email = "adriana@example.com",
                RegistrationDate = DateTime.Now.AddMonths(-2)
            };
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save updated info to the database (mock)
            // Example: Save User to DB

            TempData["SuccessMessage"] = "Profile updated successfully!";
            return RedirectToPage("/Account/Profile");
        }
    }
}
