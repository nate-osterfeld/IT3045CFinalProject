
using System.ComponentModel.DataAnnotations.Schema;

namespace IT3045CFinalProject.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string? PetType { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Color { get; set; }
        public string? Gender { get; set; }

        [ForeignKey(nameof(TeamMemberId))]
        public int TeamMemberId { get; set; }
        public TeamMember? TeamMember { get; set; }
    }
}
