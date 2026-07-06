using Common.Dtos.Instance;
using DataAccess.Domain.Instance;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.Instance
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutInstanceMovementMapper
    {
        public partial WorkoutInstanceMovementDto WorkoutInstanceMovementToWorkoutInstanceMovementDto(WorkoutInstanceMovement model);
        public partial WorkoutInstanceMovement WorkoutInstanceMovementDtoToWorkoutInstanceMovement(WorkoutInstanceMovementDto model);
    }
}
