using IT3045CFinalProject.Data;
using IT3045CFinalProject.Models;

namespace IT3045CFinalProject.Seeds
{
    public static class HobbySeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Hobbies.Any()) return;

            var teamMembers = context.TeamMembers.ToList();
            var hobbies = new[]
            {
                new Hobby
                {
                    HobbyYN = "Yes",
                    Artistic = "Crafting",
                    Athletic = "None",
                    Musical = "Singing",
                    Academic = "Reading",
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Audrey Ryser")?.Id ?? throw new InvalidOperationException("Missing team member")

                },
                new Hobby
                {
                    HobbyYN = "Yes",
                    Artistic = "Drawing",
                    Athletic = "Weight Lifting",
                    Musical = "Trumpet",
                    Academic = "Reading",
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Jaxon Coniglio")?.Id ?? throw new InvalidOperationException("Missing team member")

                },
                new Hobby
                {
                    HobbyYN = "Yes",
                    Artistic = "Photography",
                    Athletic = "Running",
                    Musical = "Guitar",
                    Academic = "Coding",
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Silas Curry")?.Id ?? throw new InvalidOperationException("Missing team member")

                }
            };

            context.Hobbies.AddRange(hobbies);
            context.SaveChanges();
        }
    }
}
