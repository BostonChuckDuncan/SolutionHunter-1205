using System.Collections.Generic;
using API.Entity;

namespace API.Dtos
{
    public class ProjectProfileDto
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string FormulaType { get; set; }
        public decimal HowLikely { get; set; }
        public decimal PointAx { get; set; }
        public decimal PointAy { get; set; }
        public decimal PointBx { get; set; }
        public decimal PointBy { get; set; }
        public bool isProjectCustom { get; set; }
        public virtual IEnumerable<Project> Projects { get; set; }
    }
}

    