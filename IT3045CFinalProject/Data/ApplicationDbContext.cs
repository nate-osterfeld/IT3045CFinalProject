using IT3045C_Final.Models;
using IT3045CFinalProject.Models;
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
        public DbSet<BreakfastFood> BreakfastFood { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
