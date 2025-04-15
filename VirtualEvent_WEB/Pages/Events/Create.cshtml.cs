using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using System.Collections.Generic;

namespace VirtualEvent_WEB.Pages.Events
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Event NewEvent { get; set; }  // Bind the NewEvent object to the form inputs

        public static List<Event> AllEvents = new List<Event>(); // Shared event list

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();  // Return to the same page if the model is invalid
            }

            // Assign a unique ID and add the event to the list
            NewEvent.Id = AllEvents.Count + 1;
            AllEvents.Add(NewEvent);

            // Redirect to ViewTrips after saving the event
            return RedirectToPage("/Events/ViewTrips");
        }
    }
}
