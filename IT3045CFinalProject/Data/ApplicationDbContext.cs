using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace IT3045CFinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
