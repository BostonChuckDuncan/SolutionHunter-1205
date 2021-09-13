using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entity;

namespace API.Data
{
    public interface ICacheMarkerRepository
    {
        Task<IEnumerable<CacheMarker>> GetAllProjectMarkers(int ProjectId);
        Task<IEnumerable<CacheMarker>> GetAllProjectGhosts(int ProjectId);
        Task<CacheMarker> GetSpecificGhost(int ProjectId, int GhostId);
        Task<int> GetCountOfGhosts(int ProjectId);
        Task<int> AddNewGhost(int ProjectId);  // returns GhostId
        Task<bool> RemoveSpecificGhost(int ProjectId, int GhostId);
        Task<bool> RemoveAllGhosts(int ProjectId);         
    }
}