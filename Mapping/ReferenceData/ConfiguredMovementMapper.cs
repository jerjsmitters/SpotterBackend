using DTOs.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Models.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class ConfiguredMovementMapper
    {
        public partial ConfiguredMovementDto ConfiguredMovementToConfiguredMovementDto(ConfiguredMovement model);
        public partial ConfiguredMovement ConfiguredMovementDtoToConfiguredMovement(ConfiguredMovementDto model);
    }
}
