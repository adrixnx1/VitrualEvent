using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VirtualEvent_WEB.Data;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages
{
    public class UsersListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public UsersListModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<User> Users { get; set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
