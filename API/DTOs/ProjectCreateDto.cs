namespace API.Dtos
{
    public class ProjectCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectProfileId { get; set; }
        public int ProjectTeamId { get; set; }
    }
}