using DataAccess.Domain.ReferenceData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EF.ModelConfigurations
{
    public class MovementConfigurationEntityConfiguration : IEntityTypeConfiguration<MovementConfiguration>
    {
        public void Configure(EntityTypeBuilder<MovementConfiguration> builder)
        {
            builder.ToTable("MovementConfigurations");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TotalSets).IsRequired();
            builder.Property(x => x.SetRepRangeLowerBound).IsRequired();
            builder.Property(x => x.SetRepRangeUpperBound).IsRequired();
            builder.Property(x => x.RestTimeSeconds).IsRequired();
        }
    }
}
