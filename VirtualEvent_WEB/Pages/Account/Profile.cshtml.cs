using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Account
{
    public class ProfileModel : PageModel
    {
        public Registration User { get; set; }
        public void OnGet()
        {
            User = new Registration
            {
                FirstName = "Adriana",
                LastName = "Rivera",
                Email = "adriana@example.com",
                RegistrationDate = DateTime.Now.AddMonths(-2)
            };
        }
    }
}
