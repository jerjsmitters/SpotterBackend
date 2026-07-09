using Common.Dtos.Instance;
using DataAccess.Domain.Instance;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using Business.Mapping.ReferenceData;

namespace Business.Mapping.Instance
{
    public static class WorkoutInstanceMovementMappingExtensions
    {
        public static WorkoutInstanceMovementDto ToDto(this WorkoutInstanceMovement model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new WorkoutInstanceMovementDto
            {
                Id = model.Id,
                StartedDateTime = model.StartedDateTime,
                CompletedDateTime = model.CompletedDateTime,
                ConfiguredMovement = model.ConfiguredMovement?.ToDto(),
                Sets = model.Sets?.ToDtos()
            };
        }

        public static List<WorkoutInstanceMovementDto> ToDtos(this List<WorkoutInstanceMovement> model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            if (model.Count == 0)
            {
                return [];
            }

            return model.Select(x => x.ToDto()).ToList();
        }

        public static WorkoutInstanceMovement ToEntity(this WorkoutInstanceMovementDto model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new WorkoutInstanceMovement
            {
                Id = model.Id,
                StartedDateTime = model.StartedDateTime,
                CompletedDateTime = model.CompletedDateTime,
                ConfiguredMovement = model.ConfiguredMovement?.ToEntity(),
                Sets = model.Sets?.ToEntities()
            };
        }

        public static List<WorkoutInstanceMovement> ToEntities(this List<WorkoutInstanceMovementDto> models)
        {
            ArgumentNullException.ThrowIfNull(models, nameof(models));

            if (models.Count == 0)
            {
                return [];
            }

            return models.Select(x => x.ToEntity()).ToList();
        }
    }
}
