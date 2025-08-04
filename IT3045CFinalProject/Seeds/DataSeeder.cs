using IT3045CFinalProject.Data;

namespace IT3045CFinalProject.Seeds
{
    public static class DataSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            TeamMemberSeeder.Seed(context);
            BreakfastFoodSeeder.Seed(context);
            HobbySeeder.Seed(context);
            PetSeeder.Seed(context);
        }
    }
}
