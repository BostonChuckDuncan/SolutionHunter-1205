using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entity
{
    [Table("Individuals")]
    public class Individual
    {
        public int IndividualId { get; set; }
        public double Fitness { get; set; }
        public int AttributeId { get; set; }
        public int OrdinalRank { get; set; }

        public int PopulationId { get; set; }
        public Population Population { get; set; }
    }
}