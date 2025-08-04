using IT3045CFinalProject.Data;
using IT3045CFinalProject.Models;

namespace IT3045CFinalProject.Seeds
{
    public static class PetSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Pets.Any()) return;

            var teamMembers = context.TeamMembers.ToList();
            var pets = new[]
            {
                new Pet
                {
                    PetType = "None",
                    Name = null,
                    Age = null,
                    Color = null,
                    Gender = null,
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Audrey Ryser")?.Id ?? throw new InvalidOperationException("Missing team member")

                },
                new Pet
                {
                    PetType = "None",
                    Name = null,
                    Age = null,
                    Color = null,
                    Gender = null,
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Jaxon Coniglio")?.Id ?? throw new InvalidOperationException("Missing team member")

                },
                new Pet
                {
                    PetType = "Dog",
                    Name = "Wilson",
                    Age = "4 years",
                    Color = "Black and Brown",
                    Gender = "Male",
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Silas Curry")?.Id ?? throw new InvalidOperationException("Missing team member")


                }
            };

            context.Pets.AddRange(pets);
            context.SaveChanges();
        }
    }
}
