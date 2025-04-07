using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using VirtualEvent_WEB.Model;

namespace VirtualEvent_WEB.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Registration NewUser { get; set; }
        public void OnGet()
        {
            NewUser = new Registration();
            // NewUser.FirstName = "John";
        }
        public IActionResult OnPost()
        {
            // string firstName = NewUser.FirstName;

            //val user input
            if (ModelState.IsValid)
            {
                //1. save the user to the database
              //  string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=CloudMeet;Trusted_Connection=True;";
               // SqlConnection conn = new SqlConnection(connectionString);
                //Create command to insert data
               // string cmdText = "INSERT INTO Users (FirstName, LastName, Email, Password, ProfileImage, DateofBirth, RegistrationDate) VALUES (@FirstName, @LastName, @Email, @Password, @ProfileImage, @DateofBirth, @RegistrationDate)";
                //2. send a confirmation email
                //3. redirect to the login page
                //4. show a message to the user
                //5. show the user the login page

                return RedirectToPage("Login");
            }
            else
            {
                return Page();
            }

        }
    }
}
