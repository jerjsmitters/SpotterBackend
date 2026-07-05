using DTOs.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Models.Template
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class MovementConfigurationMapper
    {
        public partial MovementConfigurationDto MovementConfigurationToMovementConfigurationDto(MovementConfiguration model);
        public partial MovementConfiguration MovementConfigurationDtoToMovementConfiguration(MovementConfigurationDto model);
    }
}
