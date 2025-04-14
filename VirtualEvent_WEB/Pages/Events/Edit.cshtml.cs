using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Events
{
    [Authorize]
    public class EditModel : PageModel
    {
        [BindProperty]
        public Event EditableEvent { get; set; }

        public IActionResult OnGet(int id)
        {
            EditableEvent = CreateModel.AllEvents.FirstOrDefault(e => e.Id == id);

            if (EditableEvent == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            var existing = CreateModel.AllEvents.FirstOrDefault(e => e.Id == EditableEvent.Id);

            if (existing != null)
            {
                existing.Title = EditableEvent.Title;
                existing.Description = EditableEvent.Description;
                existing.ImageUrl = EditableEvent.ImageUrl;
                existing.Date = EditableEvent.Date;
            }

            return RedirectToPage("/Index");
        }
    }
}
