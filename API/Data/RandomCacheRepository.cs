using System.Threading.Tasks;

namespace HunterServer.Data
{
    public class RandomCacheRepository : IRandomCacheRepository
    {
        public Task ExtendCache()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GetRandomInt(int maxDecimal, int ProjectId, string MarkerName = "")
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InitCacheMarker0()
        {
            throw new System.NotImplementedException();
        }

        public void SetMarker(string markerName, bool isStarting, int binaryLength, int processId)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> TestAvailableSpace(int ProjectId, int numHexDigits)
        {
            throw new System.NotImplementedException();
        }
    }
}