using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Trips
{
    public class ListModel : PageModel
    {
        public List<Trip> Trips { get; set; }

        public void OnGet()
        {
            Trips = TripStore.Trips;
        }
    }
}
