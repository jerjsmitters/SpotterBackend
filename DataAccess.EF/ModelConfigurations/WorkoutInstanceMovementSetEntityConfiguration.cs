using DataAccess.Domain.Instance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EF.ModelConfigurations
{
    public class WorkoutInstanceMovementSetEntityConfiguration : IEntityTypeConfiguration<WorkoutInstanceMovementSet>
    {
        public void Configure(EntityTypeBuilder<WorkoutInstanceMovementSet> builder)
        {
            builder.ToTable("WorkoutInstanceMovementSets");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.SetNumber).IsRequired();
            builder.Property(x => x.Reps).IsRequired();

            builder.Property(x => x.StartedDateTime).IsRequired();
            builder.Property(x => x.CompletedDateTime).IsRequired(false);
        }
    }
}
