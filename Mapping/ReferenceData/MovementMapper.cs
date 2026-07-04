using DTOs.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Models.Template
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class MovementMapper
    {
        public partial MovementDto MovementToMovementDto(Movement model);
        public partial Movement MovementDtoToMovement(MovementDto model);
    }
}
