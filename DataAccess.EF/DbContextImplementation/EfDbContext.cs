using DataAccess.Domain.Instance;
using DataAccess.Domain.ReferenceData;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.DbContextImplementation
{
    public class EfDbContext(DbContextOptions<EfDbContext> dbContextOptions) : DbContext(dbContextOptions)
    {
        //Reference Data
        public DbSet<ConfiguredMovement> ConfiguredMovements { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<MovementConfiguration> MovementConfigurations{ get; set; }
        public DbSet<WorkoutTemplate> WorkoutTemplates { get; set; }

        //Instance
        public DbSet<WorkoutInstance> WorkoutInstances { get; set; }
        public DbSet<WorkoutInstanceMovement> WorkoutInstanceMovements { get; set; }
        public DbSet<WorkoutInstanceMovementSet> WorkoutInstanceMovementSets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all IEntityTypeConfiguration implementations in this assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }

}
