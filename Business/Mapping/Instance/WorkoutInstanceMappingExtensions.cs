using Common.Dtos.Instance;
using Business.Mapping.Instance;
using Riok.Mapperly.Abstractions;
using DataAccess.Domain.Base;
using DataAccess.Domain.ReferenceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Domain.Instance;
using Common.Dtos.ReferenceData;
using Business.Mapping.ReferenceData;

namespace Business.Mapping.Instance
{
    public static class WorkoutInstanceMappingExtensions
    {
        public static WorkoutInstanceDto ToDto(this WorkoutInstance model)
        {
            ArgumentNullException.ThrowIfNull(model);

            return new WorkoutInstanceDto()
            {
                Id = model.Id,
                CompletedDateTime = model.CompletedDateTime,
                StartedDateTime = model.StartedDateTime,
                WorkoutTemplate = model.WorkoutTemplate?.ToDto(),
                WorkoutInstanceMovements = model.WorkoutInstanceMovements?.ToDtos()
            };
        }

        public static List<WorkoutInstanceDto> ToDtos(this List<WorkoutInstance> models)
        {
            ArgumentNullException.ThrowIfNull(models);

            if (models.Count == 0)
            {
                return [];
            }

            return models.Select(x => x.ToDto()).ToList();
        }

        public static WorkoutInstance ToEntity(this WorkoutInstanceDto dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            return new WorkoutInstance()
            {
                Id = dto.Id,
                CompletedDateTime = dto.CompletedDateTime,
                StartedDateTime = dto.StartedDateTime,
                WorkoutTemplate = dto.WorkoutTemplate?.ToEntity(),
                WorkoutInstanceMovements = dto.WorkoutInstanceMovements?.ToEntities()
            };
        }

        public static List<WorkoutInstance> ToEntities(this List<WorkoutInstanceDto> dtos)
        {
            ArgumentNullException.ThrowIfNull(dtos);

            if (dtos.Count == 0)
            {
                return [];
            }

            return dtos.Select(x => x.ToEntity()).ToList();
        }

    }
}