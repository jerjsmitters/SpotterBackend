

using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutTemplateMapper : IMapper<WorkoutTemplate, WorkoutTemplateDto>
    {
        public partial WorkoutTemplateDto ToDto(WorkoutTemplate model);
        public partial WorkoutTemplate ToEntity(WorkoutTemplateDto model);
    }
}
