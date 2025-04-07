using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Registration NewUser { get; set; }

        public static List<Registration> Users = new List<Registration>();
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Users.Add(NewUser);

            HttpContext.Session.SetString("UserEmail", NewUser.Email);

            return RedirectToPage("/Index");
        }
    }
}