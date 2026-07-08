using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class MovementMapper : IMapper<Movement, MovementDto>
    {
        public partial MovementDto ToDto(Movement model);
        public partial Movement ToEntity(MovementDto model);
    }
}
