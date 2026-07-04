using DTOs.Instance;
using Riok.Mapperly.Abstractions;

namespace Models.Instance
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutInstanceMovementSetMapper
    {
        public partial WorkoutInstanceMovementSetDto WorkoutInstanceMovementSetToWorkoutInstanceMovementSetDto(WorkoutInstanceMovementSet model);
        public partial WorkoutInstanceMovementSet WorkoutInstanceMovementSetDtoToWorkoutInstanceMovementSet(WorkoutInstanceMovementSetDto model);
    }
}
