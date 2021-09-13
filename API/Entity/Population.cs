using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entity
{
    [Table("Populations")]
    public class Population
    {
        public int PopulationId { get; set; }
        public int TemplateId { get; set; }
        public int OperationalParmsId { get; set; }
        public int IndividualIdToMany { get; set; }
        public int PopulationSize { get; set; }
        public bool PopSizeVaries { get; set; }
        public int PopulationMax { get; set; }
        public int PopulationMin { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public ICollection<Individual> Individuals { get; set; }

        public ICollection<Attribute> Attributes { get; set; }
    }

}