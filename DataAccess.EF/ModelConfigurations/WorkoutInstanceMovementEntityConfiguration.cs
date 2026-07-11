using DataAccess.Domain.Instance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EF.ModelConfigurations
{
    public class WorkoutInstanceMovementEntityConfiguration : IEntityTypeConfiguration<WorkoutInstanceMovement>
    {
        public void Configure(EntityTypeBuilder<WorkoutInstanceMovement> builder)
        {
            builder.ToTable("WorkoutInstanceMovements");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StartedDateTime).IsRequired();
            builder.Property(x => x.CompletedDateTime).IsRequired(false);

            builder.HasOne(x => x.ConfiguredMovement).WithMany().HasForeignKey("ConfiguredMovementId");
            builder.HasMany(x => x.Sets).WithOne().HasForeignKey("WorkoutInstanceMovementId");
        }
    }
}
