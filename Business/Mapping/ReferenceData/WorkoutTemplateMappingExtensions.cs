using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Mapping.ReferenceData
{
    public static class WorkoutTemplateMappingExtensions
    {
        public static WorkoutTemplateDto ToDto(this WorkoutTemplate model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new WorkoutTemplateDto
            {
                Id = model.Id,
                Name = model.Name,
                ConfiguredMovements = model.ConfiguredMovements?.ToDtos(),
                
            };
        }

        public static List<WorkoutTemplateDto> ToDtos(this List<WorkoutTemplate> model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            if (model.Count == 0)
            {
                return [];
            }

            return model.Select(x => x.ToDto()).ToList();
        }

        public static WorkoutTemplate ToEntity(this WorkoutTemplateDto model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new WorkoutTemplate
            {
                Id = model.Id,
                Name = model.Name,
                ConfiguredMovements = model.ConfiguredMovements?.ToEntities()
            };
        }

        public static List<Movement> ToEntities(this List<MovementDto> models)
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
