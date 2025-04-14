using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Events
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Event NewEvent { get; set; }

        public static List<Event> AllEvents = new List<Event>(); // shared list for demo

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            NewEvent.Id = AllEvents.Count + 1;
            AllEvents.Add(NewEvent);

            return RedirectToPage("/Index");
        }
    }
}
