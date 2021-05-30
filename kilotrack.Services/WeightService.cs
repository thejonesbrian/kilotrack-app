using System;
using System.Linq;
using System.Collections.Generic;
using kilotrack.Data;
using kilotrack.Data.Models;

namespace kilotrack.Services
{
    public class WeightService : IWeightService
    {
        private readonly KiloTrackDbContext _db;
        public WeightService(KiloTrackDbContext db)
        {
            _db = db;
        }
        public void AddWeight(Weight weight)
        {
            throw new NotImplementedException();
        }

        public void DeleteWeight(int weightId)
        {
            throw new NotImplementedException();
        }

        public List<Weight> GetAllWeights()
        {
            return _db.Weights.ToList();
        }

        public Weight GetWeight(int weightId)
        {
            throw new NotImplementedException();
        }
    }
}
