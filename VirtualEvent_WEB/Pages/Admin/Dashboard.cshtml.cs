using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using System.Collections.Generic;
using System.Linq;
using VirtualEvent_WEB.Pages.Account;

namespace VirtualEvent_WEB.Pages.Admin
{
    public class DashboardModel : PageModel
    {
        public static List<Registration> UsersStore = RegisterModel.Users; // Replace with DB context later
        public List<Registration> Users { get; set; }

        public void OnGet()
        {
            Users = UsersStore;
        }

        public IActionResult OnPostDelete(string emailToDelete)
        {
            var user = UsersStore.FirstOrDefault(u => u.Email == emailToDelete && !u.IsAdmin);
            if (user != null)
            {
                UsersStore.Remove(user);
            }

            return RedirectToPage();
        }
    }
}
