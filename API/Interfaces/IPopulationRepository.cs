using System.Threading.Tasks;
using API.Entity;

namespace API.Data
{
    public interface IPopulationRepository
    {
        Task<Population> CreateNewPopulation(int ProjectId);
        Task<bool> AddNewPopulation(int ProjectId, Population newPop);
        Task<bool> TestAllFitness(int ProjectId, int PopulationId);
        Task<bool> AdjustAccordingToProfile(int ProjectId);
        Task<bool> TestForCompleteness(int ProjectId);
        
    }
}