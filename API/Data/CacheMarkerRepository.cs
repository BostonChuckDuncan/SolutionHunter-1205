using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;

namespace API.Entity
{
    public class CacheMarkerRepository : ICacheMarkerRepository
    {
        public Task<int> AddNewGhost(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CacheMarker>> GetAllProjectGhosts(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CacheMarker>> GetAllProjectMarkers(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GetCountOfGhosts(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CacheMarker> GetSpecificGhost(int ProjectId, int GhostId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveAllGhosts(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveSpecificGhost(int ProjectId, int GhostId)
        {
            throw new System.NotImplementedException();
        }
    }
}