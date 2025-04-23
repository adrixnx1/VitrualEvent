using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VirtualEvent_WEB.Model;
using VirtualEvent_WEB.Services;

namespace VirtualEvent_WEB.Pages.Bookings
{
    [Authorize]
    public class MyBookingsModel : PageModel
    {
        public List<Booking> UserBookings { get; set; }

        public IActionResult OnGet()
        {
            var userEmail = User.Identity?.Name;
            UserBookings = BookingData.Bookings
                .Where(b => b.UserEmail == userEmail)
                .ToList();

            return Page();
        }

        public IActionResult OnPostCancel(Guid id)
        {
            var booking = BookingData.Bookings.FirstOrDefault(b => b.Id == id);
            if (booking != null && booking.UserEmail == User.Identity?.Name)
            {
                booking.IsCanceled = true;
            }

            return RedirectToPage();
        }
    }
}
