using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entity;

namespace API.Data
{
    public class IndividualRepository : IIndividualRepository
    {
        public Task<bool> AddAttribute(int IndividualId, int AttributeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> AddNewIndividual(int PopulationId, Individual indiv)
        {
            throw new System.NotImplementedException();
        }

        public Task<Individual> CreateCompliantIndividual(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Individual>> GetAllIdFitness()
        {
            throw new System.NotImplementedException();
        }

        public Task<Individual> MarryAnotherIndividual(int coupleSize = 2)
        {
            throw new System.NotImplementedException();
        }

        public Task<Individual> ProduceAChild(int numChildenAllowed = 1)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveIndividual(int Individual)
        {
            throw new System.NotImplementedException();
        }

        public Task<Individual> SaveBestIndividual(int Individual, bool addToExisting = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SetIndividualFitness(int IndividualId, double Fitness)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SetIndividualOrdinal(int IndividualId, int ordinalRank)
        {
            throw new System.NotImplementedException();
        }
    }
}