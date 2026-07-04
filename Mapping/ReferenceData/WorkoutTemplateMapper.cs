using DTOs.ReferenceData;
using Riok.Mapperly.Abstractions;

namespace Models.Template
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutTemplateMapper
    {
        public partial WorkoutTemplateDto WorkoutTemplateToWorkoutTemplateDto(WorkoutTemplate model);
        public partial WorkoutTemplate WorkoutTemplateDtoToWorkoutTemplate(WorkoutTemplateDto model);
    }
}
