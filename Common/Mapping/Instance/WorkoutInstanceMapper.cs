using DTOs.Instance;
using Models.Base;
using Models.Template;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Models.Instance
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutInstanceMapper
    {
        public partial WorkoutInstanceDto WorkoutInstanceToWorkoutInstanceDto(WorkoutInstance model);
        public partial WorkoutInstance WorkoutInstancDtoToWorkoutInstance(WorkoutInstanceDto model);
    }
}
