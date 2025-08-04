using System.ComponentModel.DataAnnotations.Schema;

namespace IT3045CFinalProject.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public string? HobbyYN { get; set; }
        public string? Artistic { get; set; }
        public string? Athletic { get; set; }
        public string? Musical { get; set; }
        public string? Academic { get; set; }

        [ForeignKey(nameof(TeamMemberId))]
        public int TeamMemberId { get; set; }
        public TeamMember? TeamMember { get; set; }
    }
}
