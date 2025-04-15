using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using System.Collections.Generic;

namespace VirtualEvent_WEB.Pages.Events
{
    public class ViewTripsModel : PageModel
    {
        public List<Event> AllEvents { get; set; } = new List<Event>();

        public void OnGet()
        {
            // Retrieve the list of all events from wherever they are stored
            AllEvents = CreateModel.AllEvents;  // This will use the static list from CreateModel
        }
    }
}
