using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using API.Entity;

namespace API.Data
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DataContext _context;
        public ProjectRepository(DataContext context) {
            _context = context;
        }

        public async Task<Project> CreateProject(Project newProj)
        {
            var proj = _context.Projects
                    .Where(b => b.Title.ToLower() == newProj.Title.ToLower());
            if (proj == null) 
            {
                await _context.Projects.AddAsync(newProj);
            }
            return newProj;
        }

        public Task<Project> GhostTheProject(int ProjectId, CacheMarker marker)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveAllGhosts(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveProject(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task ReplaceProjectWithGhost(int ProjectId, int GhostId)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProjectProfile> GetProfile(int ProfileID) 
        {
            throw new System.NotImplementedException();
        }

        public Task<List<int>> GetGhostIds(int ProjectId)
        {
            throw new System.NotImplementedException();
        }
    }
}