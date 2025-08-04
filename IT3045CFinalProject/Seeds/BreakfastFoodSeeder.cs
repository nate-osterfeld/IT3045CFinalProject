using IT3045CFinalProject.Data;
using IT3045CFinalProject.Models;

namespace IT3045CFinalProject.Seeds
{
    public static class BreakfastFoodSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.BreakfastFood.Any()) return;

            var teamMembers = context.TeamMembers.ToList();
            var breakfastFoods = new[]
            {
                new BreakfastFood
                {
                    BreakfastYN = "Yes",
                    Drink = "Orange Juice",
                    Protein = "Sausage Links",
                    Carbs = "Pancakes",
                    FruitsOrVeggies = null,
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Audrey Ryser")?.Id ?? throw new InvalidOperationException("Missing team member")

                },
                new BreakfastFood
                {
                    BreakfastYN = "Yes",
                    Drink = "Coffee",
                    Protein = "Bacon",
                    Carbs = "Pancakes",
                    FruitsOrVeggies = null,
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Jaxon Coniglio")?.Id ?? throw new InvalidOperationException("Missing team member")

                },
                new BreakfastFood
                {
                    BreakfastYN = "Yes",
                    Drink = "Milk",
                    Protein = "Eggs",
                    Carbs = "Toast",
                    FruitsOrVeggies = "Apple",
                    TeamMemberId = teamMembers.FirstOrDefault(m => m.FullName == "Silas Curry")?.Id ?? throw new InvalidOperationException("Missing team member")

                }
            };

            context.BreakfastFood.AddRange(breakfastFoods);
            context.SaveChanges();
        }
    }
}
