using DataAccess.Domain.ReferenceData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EF.ModelConfigurations
{
    public class ConfiguredMovementEntityConfiguration : IEntityTypeConfiguration<ConfiguredMovement>
    {
        public void Configure(EntityTypeBuilder<ConfiguredMovement> builder)
        {
            builder.ToTable("ConfiguredMovements");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Sequence).IsRequired();

            builder.HasOne(x => x.Movement).WithMany().HasForeignKey("MovementId");
            builder.HasOne(x => x.MovementConfiguration).WithMany().HasForeignKey("MovementConfigurationId");
        }
    }
}
