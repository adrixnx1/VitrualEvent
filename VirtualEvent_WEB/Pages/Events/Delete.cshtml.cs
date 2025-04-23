using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using System.Linq;

namespace VirtualEvent_WEB.Pages.Events
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Event TripToDelete { get; set; }

        public IActionResult OnGet(int id)
        {
            TripToDelete = EventData.Events.FirstOrDefault(e => e.Id == id);
            if (TripToDelete == null)
                return RedirectToPage("/Events/ViewTrips");

            return Page();
        }

        public IActionResult OnPost()
        {
            var trip = EventData.Events.FirstOrDefault(e => e.Id == TripToDelete.Id);
            if (trip != null)
            {
                EventData.Events.Remove(trip);
            }

            return RedirectToPage("/Events/ViewTrips");
        }
    }
}

