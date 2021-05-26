using kilotrack.Data.Models;
using System.Collections.Generic;

namespace kilotrack.Services
{
    public interface IWeightService
    {
        public List<Weight> GetAllWeights();
        public Weight GetWeight(int weightId);
        public void AddWeight(Weight weight);
        public void DeleteWeight(int weightId);

    }
}