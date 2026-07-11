using DataAccess.Domain.ReferenceData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EF.ModelConfigurations
{
    public class WorkoutTemplateEntityConfiguration : IEntityTypeConfiguration<WorkoutTemplate>
    {
        public void Configure(EntityTypeBuilder<WorkoutTemplate> builder)
        {
            builder.ToTable("WorkoutTemplates");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.HasMany(x => x.ConfiguredMovements).WithOne().HasForeignKey("WorkoutTemplateId");
        }
    }
}
