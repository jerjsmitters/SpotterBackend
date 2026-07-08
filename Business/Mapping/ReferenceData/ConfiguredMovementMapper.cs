using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class ConfiguredMovementMapper : IMapper<ConfiguredMovement, ConfiguredMovementDto>
    {
        public partial ConfiguredMovementDto ToDto(ConfiguredMovement model);
        public partial ConfiguredMovement ToEntity(ConfiguredMovementDto model);
    }
}
