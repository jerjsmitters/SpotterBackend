using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class ConfiguredMovementMapper
    {
        public partial ConfiguredMovementDto ConfiguredMovementToConfiguredMovementDto(ConfiguredMovement model);
        public partial ConfiguredMovement ConfiguredMovementDtoToConfiguredMovement(ConfiguredMovementDto model);
    }
}
