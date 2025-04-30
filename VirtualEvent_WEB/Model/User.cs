using Microsoft.AspNetCore.Identity;

namespace VirtualEvent_WEB.Model
{
    // Make User inherit from IdentityUser
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ProfileImage { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int AccountTypeID { get; set; }
    }
}
