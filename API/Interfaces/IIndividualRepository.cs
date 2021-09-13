using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entity;

namespace API.Data
{
    public interface IIndividualRepository
    {
       Task<Individual> CreateCompliantIndividual(int ProjectId);
       Task<bool> AddNewIndividual(int PopulationId, Individual indiv);
       Task<bool> AddAttribute(int IndividualId, int AttributeId);
       Task<bool> SetIndividualFitness(int IndividualId, double Fitness);
       Task<IEnumerable<Individual>> GetAllIdFitness();
       Task<bool>  SetIndividualOrdinal(int IndividualId, int ordinalRank);
       Task<bool> RemoveIndividual(int Individual);
       Task<Individual> SaveBestIndividual(int Individual, bool addToExisting = false);
       Task<Individual> MarryAnotherIndividual(int coupleSize = 2);
       Task<Individual> ProduceAChild(int numChildenAllowed = 1);
        
    }
}