using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entity
{
    [Table("ProjectProfiles")]
    public class ProjectProfile
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string FormulaType { get; set; }
        [Column(TypeName = "decimal(30,8")]
        public decimal HowLikely { get; set; }
        [Column(TypeName = "decimal(30,8")]
        public decimal PointAx { get; set; }
        [Column(TypeName = "decimal(30,8")]
        public decimal PointAy { get; set; }
        [Column(TypeName = "decimal(30,8")]
        public decimal PointBx { get; set; }
        [Column(TypeName = "decimal(30,8")]
        public decimal PointBy { get; set; }
    }
}