using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entity
{
    [Table("TeamMembers")]
    public class TeamMember {
        public int TeamMemberId { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
    }
}