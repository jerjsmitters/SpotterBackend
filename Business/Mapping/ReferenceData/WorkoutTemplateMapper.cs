

using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Business.Mapping.ReferenceData
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutTemplateMapper
    {
        public partial WorkoutTemplateDto WorkoutTemplateToWorkoutTemplateDto(WorkoutTemplate model);
        public partial WorkoutTemplate WorkoutTemplateDtoToWorkoutTemplate(WorkoutTemplateDto model);
    }
}
