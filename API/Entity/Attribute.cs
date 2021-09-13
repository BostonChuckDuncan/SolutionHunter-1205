using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entity
{
    [Table("Attributes")]
    public class Attribute
    {
        public string AttributeType { get; set; }

        public int AttributeId { get; set; }

        public Individual Individual { get; set; }
    }
}