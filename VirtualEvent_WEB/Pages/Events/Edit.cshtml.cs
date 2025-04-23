using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using System.Linq;

namespace VirtualEvent_WEB.Pages.Events
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Event EditableEvent { get; set; }

        public IActionResult OnGet(int id)
        {
            EditableEvent = EventData.Events.FirstOrDefault(e => e.Id == id);
            if (EditableEvent == null)
                return RedirectToPage("/Events/ViewTrips");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var existing = EventData.Events.FirstOrDefault(e => e.Id == EditableEvent.Id);
            if (existing != null)
            {
                existing.Title = EditableEvent.Title;
                existing.Description = EditableEvent.Description;
                existing.Date = EditableEvent.Date;
                existing.ImageUrl = EditableEvent.ImageUrl;
            }

            return RedirectToPage("/Events/ViewTrips");
        }
    }
}
