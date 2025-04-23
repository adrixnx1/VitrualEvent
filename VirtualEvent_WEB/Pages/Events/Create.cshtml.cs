using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Events
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Event NewEvent { get; set; }

        public IActionResult OnGet()
        {
            NewEvent = new Event(); // initialize form
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // redisplay form with errors
            }

            // Assign a unique ID
            NewEvent.Id = EventData.Events.Count + 1;

            // Save to global list
            EventData.Events.Add(NewEvent);

            // Redirect to ViewTrips page
            return RedirectToPage("/Events/ViewTrips");
        }
    }
}

