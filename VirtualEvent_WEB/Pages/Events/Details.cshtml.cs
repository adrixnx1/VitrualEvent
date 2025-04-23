using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using System.Linq;

namespace VirtualEvent_WEB.Pages.Events
{
    public class DetailsModel : PageModel
    {
        public Event TripDetails { get; set; }

        public IActionResult OnGet(int id)
        {
            TripDetails = EventData.Events.FirstOrDefault(e => e.Id == id);
            if (TripDetails == null)
                return RedirectToPage("/Events/ViewTrips");

            return Page();
        }
    }
}

