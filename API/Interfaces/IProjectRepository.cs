using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entity;

namespace API.Data
{
    public interface IProjectRepository
    {
        Task<Project> CreateProject(Project newProj);
        Task<Project> GhostTheProject(int ProjectId, CacheMarker marker);
        Task ReplaceProjectWithGhost(int ProjectId, int GhostId);
        Task<bool> RemoveAllGhosts(int ProjectId);
        Task<bool> RemoveProject(int ProjectId);
        Task<ProjectProfile> GetProfile(int ProfileID);
        Task<List<int>> GetGhostIds(int ProjectId);
    }
}