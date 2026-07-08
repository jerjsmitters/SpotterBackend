using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class MovementConfigurationMapper : IMapper<MovementConfiguration, MovementConfigurationDto>
    {
        public partial MovementConfigurationDto ToDto(MovementConfiguration model);
        public partial MovementConfiguration ToEntity(MovementConfigurationDto model);
    }
}
