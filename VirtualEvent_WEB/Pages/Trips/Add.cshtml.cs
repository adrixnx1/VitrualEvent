using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Trips
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public TripInputModel Trip { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save to TripStore
            TripStore.Trips.Add(new Trip
            {
                TripName = Trip.TripName,
                Country = Trip.Country,
                Location = Trip.Location,
                Date = Trip.Date
            });

            // Redirect to list page
            return RedirectToPage("/Trips/List");
        }

        public class TripInputModel
        {
            [Required]
            public string TripName { get; set; }

            [Required]
            public string Country { get; set; }

            [Required]
            public string Location { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime Date { get; set; }
        }
    }
}
