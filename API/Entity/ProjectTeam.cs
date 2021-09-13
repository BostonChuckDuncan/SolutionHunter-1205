using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entity
{
    [Table("ProjectTeams")]
    public class ProjectTeam 
    {
        public int ProjectTeamId { get; set; }
        public int ProjectId { get; set; }
        public int TeamMemberId { get; set; }
    }
}