using Microsoft.EntityFrameworkCore;
using Models.Instance;
using Models.ReferenceData;
using Models.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.EF
{
    public class EfDbContext : DbContext
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
