using System.Threading.Tasks;
using API.Entity;

namespace API.Data
{
    public class OperationalProfileRepository : IOperationalProfileRepository
    {
        public Task<bool> AddOrReplaceProfile(ProjectProfile profile)
        {
            throw new System.NotImplementedException();
        }
    }
}