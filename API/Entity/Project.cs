using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entity
{
    [Table("Projects")]
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectProfileId { get; set; }
        public int PopulationId { get; set; }

        public bool isGhosting { get; set; }
        public ICollection<Population> Spirits { get; set; }
    }
}