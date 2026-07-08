using Common.Dtos.Instance;
using DataAccess.Domain.Instance;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.Instance
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutInstanceMovementSetMapper : IMapper<WorkoutInstanceMovementSet, WorkoutInstanceMovementSetDto>
    {
        public partial WorkoutInstanceMovementSetDto ToDto(WorkoutInstanceMovementSet model);
        public partial WorkoutInstanceMovementSet ToEntity(WorkoutInstanceMovementSetDto model);
    }
}
