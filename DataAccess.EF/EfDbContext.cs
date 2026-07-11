using DataAccess.Domain.Instance;
using DataAccess.Domain.ReferenceData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.EF
{
    public class EfDbContext(IConfiguration configuration) : DbContext
    {
        private readonly IConfiguration _config = configuration;

        //Reference Data
        public DbSet<ConfiguredMovement> ConfiguredMovements { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<MovementConfiguration> MovementConfigurations{ get; set; }
        public DbSet<WorkoutTemplate> WorkoutTemplates { get; set; }

        //Instance
        public DbSet<WorkoutInstance> WorkoutInstances { get; set; }
        public DbSet<WorkoutInstanceMovement> WorkoutInstanceMovements { get; set; }
        public DbSet<WorkoutInstanceMovementSet> WorkoutInstanceMovementSets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all IEntityTypeConfiguration implementations in this assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }

}
