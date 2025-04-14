using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Events
{
    public class DetailsModel : PageModel
    {
        public Event Event { get; set; }

        public IActionResult OnGet(int id)
        {
            var found = CreateModel.AllEvents.FirstOrDefault(e => e.Id == id);

            if (found == null)
                return NotFound();

            Event = found;
            return Page();
        }
    }
}
