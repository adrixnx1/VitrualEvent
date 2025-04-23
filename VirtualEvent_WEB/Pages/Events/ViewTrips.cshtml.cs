using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using System.Collections.Generic;

namespace VirtualEvent_WEB.Pages.Events
{
    public class ViewTripsModel : PageModel
    {
        public List<Event> AllEvents { get; set; }

        public void OnGet()
        {
            AllEvents = EventData.Events;
        }
    }
}

