using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Account
{
    public class UsersListModel : PageModel
    {
        public List<Registration> AllUsers { get; set; }

        public void OnGet()
        {
            // Reference the shared in-memory user list
            AllUsers = RegisterModel.Users;
        }
    }
}

