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
using Common.Dtos.ReferenceData;

namespace Business.Mapping.Instance
{
    public static class WorkoutInstanceMappingExtensions
    {
        public static WorkoutInstanceDto ToDto(this WorkoutInstance model)
        {
            return null;
         
        }

        public static List<WorkoutInstanceDto> ToDtos(this List<WorkoutInstance> model)
        {
            return null;

        }

        public static WorkoutInstance ToEntity(this WorkoutInstanceDto model)
        {
            return null;

        }
    }
}