using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public List<Event> Events { get; set; }

        public void OnGet()
        {
            Events = new List<Event>
            {
                new Event { Id = 1, Title = "Tech Innovators 2025", Description = "Explore the future of tech.", ImageUrl = "https://source.unsplash.com/400x200/?tech", Date = DateTime.Now.AddDays(10) },
                new Event { Id = 2, Title = "Virtual Design Summit", Description = "UI/UX trends online.", ImageUrl = "https://source.unsplash.com/400x200/?design", Date = DateTime.Now.AddDays(15) },
                new Event { Id = 3, Title = "Remote Work Panel", Description = "Productivity + flexibility.", ImageUrl = "https://source.unsplash.com/400x200/?remote,work", Date = DateTime.Now.AddDays(20) }
            };

        }
    }
}
