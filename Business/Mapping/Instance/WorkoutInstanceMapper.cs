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
    [Mapper]
    public partial class WorkoutInstanceMapper : IMapper<WorkoutInstance, WorkoutInstanceDto>
    {
        public partial WorkoutInstanceDto ToDto(WorkoutInstance model);
        public partial WorkoutInstance ToEntity(WorkoutInstanceDto model);
    }
}