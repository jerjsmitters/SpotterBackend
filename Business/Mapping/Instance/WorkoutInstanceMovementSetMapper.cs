using Common.Dtos.Instance;
using DataAccess.Domain.Instance;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.Instance
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutInstanceMovementSetMapper
    {
        public partial WorkoutInstanceMovementSetDto WorkoutInstanceMovementSetToWorkoutInstanceMovementSetDto(WorkoutInstanceMovementSet model);
        public partial WorkoutInstanceMovementSet WorkoutInstanceMovementSetDtoToWorkoutInstanceMovementSet(WorkoutInstanceMovementSetDto model);
    }
}
