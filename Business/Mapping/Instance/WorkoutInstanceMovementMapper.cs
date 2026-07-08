using Common.Dtos.Instance;
using DataAccess.Domain.Instance;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.Instance
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutInstanceMovementMapper : IMapper<WorkoutInstanceMovement, WorkoutInstanceMovementDto>
    {
        public partial WorkoutInstanceMovementDto ToDto(WorkoutInstanceMovement model);
        public partial WorkoutInstanceMovement ToEntity(WorkoutInstanceMovementDto model);
    }
}
