using System.Threading.Tasks;
using API.Entity;

namespace API.Data
{
    public interface IOperationalProfileRepository
    {
         Task<bool> AddOrReplaceProfile(ProjectProfile profile);
    }
}