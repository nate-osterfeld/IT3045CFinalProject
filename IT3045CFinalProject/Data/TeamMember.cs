using System;
using Microsoft.Identity.Client;

namespace IT3045CFinalProject.Data
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string CollegeProgram { get; set; }
        public string YearInProgram { get; set; }
    }
}
