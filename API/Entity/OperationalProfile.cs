namespace API.Entity
{
    public class OperationalProfile
    {
        public int OperationalProfileId { get; set; }
        public string templateName { get; set; }
        public int ProjectId { get; set; }
        public ProjectProfile gap { get; set; }
        public ProjectProfile mutation { get; set; }
        public ProjectProfile virus { get; set; }
        public ProjectProfile parent { get; set; }
        public ProjectProfile parentSim { get; set; }
        public ProjectProfile parentContrib { get; set; }
        public ProjectProfile childSurvive { get; set; }
    }
}