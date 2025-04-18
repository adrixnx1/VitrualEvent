using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Events
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Event EditableEvent { get; set; }

        public static List<Event> AllEvents => CreateModel.AllEvents;

        public IActionResult OnGet(int id)
        {
            EditableEvent = AllEvents.FirstOrDefault(e => e.Id == id);
            if (EditableEvent == null)
                return RedirectToPage("/Events/ViewTrips");

            return Page();
        }

        public IActionResult OnPost()
        {
            var existing = AllEvents.FirstOrDefault(e => e.Id == EditableEvent.Id);
            if (existing != null)
            {
                existing.Title = EditableEvent.Title;
                existing.Description = EditableEvent.Description;
                existing.Date = EditableEvent.Date;
            }

            return RedirectToPage("/Events/ViewTrips");
        }
    }
}
