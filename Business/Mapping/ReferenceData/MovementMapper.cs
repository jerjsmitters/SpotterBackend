using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class MovementMapper
    {
        public partial MovementDto MovementToMovementDto(Movement model);
        public partial Movement MovementDtoToMovement(MovementDto model);
    }
}
