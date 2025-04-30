using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VirtualEvent_WEB.Model; // Include your custom User class

namespace VirtualEvent_WEB.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>  // Inherit from IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Event> Events { get; set; }
        // Identity handles User, so no need for DbSet<User>
    }
}
