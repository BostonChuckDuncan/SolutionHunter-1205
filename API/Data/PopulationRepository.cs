using System.Threading.Tasks;
using API.Entity;

namespace API.Data
{
    public class PopulationRepository : IPopulationRepository
    {
        public Task<bool> AddNewPopulation(int ProjectId, Population newPop)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> AdjustAccordingToProfile(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Population> CreateNewPopulation(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> TestAllFitness(int ProjectId, int PopulationId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> TestForCompleteness(int ProjectId)
        {
            throw new System.NotImplementedException();
        }
    }
}