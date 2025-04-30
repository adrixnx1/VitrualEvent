using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string AccountType { get; set; }
}
