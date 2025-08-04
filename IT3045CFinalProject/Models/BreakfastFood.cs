using System.ComponentModel.DataAnnotations.Schema;

namespace IT3045CFinalProject.Models
{
    public class BreakfastFood
    {
        public int Id { get; set; }
        public string? BreakfastYN { get; set; }
        public string? Drink { get; set; }
        public string? Protein { get; set; }
        public string? Carbs { get; set; }
        public string? FruitsOrVeggies { get; set; }

        [ForeignKey(nameof(TeamMemberId))]
        public int TeamMemberId { get; set; }
        public TeamMember? TeamMember { get; set; }
    }
}