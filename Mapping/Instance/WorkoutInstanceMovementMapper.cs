using DTOs.Instance;
using Riok.Mapperly.Abstractions;

namespace Models.Instance
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutInstanceMovementMapper
    {
        public partial WorkoutInstanceMovementDto WorkoutInstanceMovementToWorkoutInstanceMovementDto(WorkoutInstanceMovement model);
        public partial WorkoutInstanceMovement WorkoutInstanceMovementDtoToWorkoutInstanceMovement(WorkoutInstanceMovementDto model);
    }
}
