using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class MovementConfigurationMapper
    {
        public partial MovementConfigurationDto MovementConfigurationToMovementConfigurationDto(MovementConfiguration model);
        public partial MovementConfiguration MovementConfigurationDtoToMovementConfiguration(MovementConfigurationDto model);
    }
}
