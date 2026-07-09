using Common.Dtos.Instance;
using DataAccess.Domain.Instance;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Mapping.Instance
{
    public static class WorkoutInstanceMovementSetMappingExtensions
    {
        public static WorkoutInstanceMovementSetDto ToDto(this WorkoutInstanceMovementSet model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new WorkoutInstanceMovementSetDto
            {
                Id = model.Id,
                StartedDateTime = model.StartedDateTime,
                CompletedDateTime = model.CompletedDateTime,
                SetNumber = model.SetNumber,
                Reps = model.Reps
            };
        }

        public static List<WorkoutInstanceMovementSetDto> ToDtos(this List<WorkoutInstanceMovementSet> model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            if (model.Count == 0)
            {
                return [];
            }

            return model.Select(x => x.ToDto()).ToList();
        }

        public static WorkoutInstanceMovementSet ToEntity(this WorkoutInstanceMovementSetDto model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new WorkoutInstanceMovementSet
            {
                Id = model.Id,
                StartedDateTime = model.StartedDateTime,
                CompletedDateTime = model.CompletedDateTime,
                SetNumber = model.SetNumber,
                Reps = model.Reps
            };
        }

        public static List<WorkoutInstanceMovementSet> ToEntities(this List<WorkoutInstanceMovementSetDto> models)
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
