using DataAccess.Domain.Instance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EF.ModelConfigurations
{
    public class WorkoutInstanceEntityConfiguration : IEntityTypeConfiguration<WorkoutInstance>
    {
        public void Configure(EntityTypeBuilder<WorkoutInstance> builder)
        {
            builder.ToTable("WorkoutInstances");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StartedDateTime).IsRequired();
            builder.Property(x => x.CompletedDateTime).IsRequired(false);

            builder.HasMany(x => x.WorkoutInstanceMovements).WithOne().HasForeignKey("WorkoutInstanceId");
            builder.HasOne(x => x.WorkoutTemplate).WithMany().HasForeignKey("WorkoutTemplateId");
        }
    }
}
