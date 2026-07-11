using DataAccess.Domain.ReferenceData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EF.ModelConfigurations
{
    public class MovementEntityConfiguration : IEntityTypeConfiguration<Movement>
    {
        public void Configure(EntityTypeBuilder<Movement> builder)
        {
            builder.ToTable("Movements");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            // Movement -> MovementConfiguration (one-to-many)
            builder.HasMany(x => x.MovementConfigurations).WithOne().HasForeignKey("MovementId");
        }
    }
}
