using Common.Dtos.Instance;
using Business.Mapping.Instance;
using Riok.Mapperly.Abstractions;
using DataAccess.Domain.Base;
using DataAccess.Domain.ReferenceData;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using DataAccess.Domain.Instance;

namespace Business.Mapping.Instance
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class WorkoutInstanceMapper
    {
        public partial WorkoutInstanceDto WorkoutInstanceToWorkoutInstanceDto(WorkoutInstance model);
        public partial WorkoutInstance WorkoutInstancDtoToWorkoutInstance(WorkoutInstanceDto model);
    }
}
