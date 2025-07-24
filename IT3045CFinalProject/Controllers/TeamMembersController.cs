using IT3045CFinalProject.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IT3045CFinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        private static List<TeamMember> data = new List<TeamMember>
        {
            new TeamMember 
            { 
                Id = 1,
                FullName = "Nate Osterfeld",
                Birthdate = new DateTime(2000, 2, 1),
                CollegeProgram = "Software Development",
                YearInProgram = "Sophomore"
            },
            new TeamMember
            {
                Id = 2,
                FullName = "Kymani Jarrett",
                Birthdate = new DateTime(2004, 6, 19),
                CollegeProgram = "Software Development",
                YearInProgram = "Sophomore"
            },
            new TeamMember
            {
                Id = 3,
                FullName = "Riddhi Mahajan",
                Birthdate = new DateTime(2005, 10, 23),
                CollegeProgram = "Software Development",
                YearInProgram = "Sophomore"
            }
        };

        // GET: api/<TeamMembersController>
        [HttpGet]
        public ActionResult<IEnumerable<TeamMember>> Get()
        {
            return Ok(data);
        }

        // GET api/<TeamMembersController>/5
        [HttpGet("{id}")]
        public ActionResult<TeamMember> Get(int id)
        {
            var teamMember = data.FirstOrDefault(x => x.Id == id);
            if (teamMember == null)
            {
                return NotFound();
            }

            return Ok(teamMember);
        }

        // POST api/<TeamMembersController>
        [HttpPost]
        public ActionResult<TeamMember> Post([FromBody] TeamMember teamMember)
        {
            if (data.Any(x => x.Id == teamMember.Id))
            {
                return BadRequest("Team member with this Id already exists");
            }

            data.Add(teamMember);

            return CreatedAtAction(nameof(Get), new { id = teamMember.Id }, teamMember);
        }

        // PUT api/<TeamMembersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TeamMember teamMember)
        {
            var existingTeamMember = data.FirstOrDefault(x => x.Id == id);
            if (existingTeamMember == null)
            {
                return NotFound();
            }

            existingTeamMember.FullName = teamMember.FullName;
            existingTeamMember.Birthdate = teamMember.Birthdate;
            existingTeamMember.CollegeProgram = teamMember.CollegeProgram;
            existingTeamMember.YearInProgram = teamMember.YearInProgram;

            return NoContent();
        }

        // DELETE api/<TeamMembersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var teamMember = data.FirstOrDefault(x => x.Id == id);
            if (teamMember == null)
            {
                return NotFound();
            }

            data.Remove(teamMember);

            return NoContent();
        }
    }
}
