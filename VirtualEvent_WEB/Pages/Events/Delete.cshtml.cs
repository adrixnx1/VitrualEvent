using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Events
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Event TripToDelete { get; set; }

        public static List<Event> AllEvents => CreateModel.AllEvents;

        public IActionResult OnGet(int id)
        {
            TripToDelete = AllEvents.FirstOrDefault(e => e.Id == id);
            if (TripToDelete == null)
                return RedirectToPage("/Events/ViewTrips");

            return Page();
        }

        public IActionResult OnPost()
        {
            var trip = AllEvents.FirstOrDefault(e => e.Id == TripToDelete.Id);
            if (trip != null)
            {
                AllEvents.Remove(trip);
            }

            return RedirectToPage("/Events/ViewTrips");
        }
    }
}
