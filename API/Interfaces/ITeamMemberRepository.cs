using System.Threading.Tasks;

namespace HunterServer.Data
{
    public interface ITeamMemberRepository
    {
         Task CreateTeamMemberRepository(int Project, int UserId);
    }
}