using kilotrack.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace kilotrack.Data
{
    public class KiloTrackDbContext : DbContext
    {
        public KiloTrackDbContext()
        {

        }
        public KiloTrackDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Weight> Weights { get; set; }
    }
}