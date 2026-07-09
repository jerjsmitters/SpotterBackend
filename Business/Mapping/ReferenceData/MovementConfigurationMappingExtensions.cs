using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Mapping.ReferenceData
{
    public static class MovementConfigurationMappingExtensions
    {
        public static MovementConfigurationDto ToDto(this MovementConfiguration model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new MovementConfigurationDto
            {
                Id = model.Id,
                TotalSets = model.TotalSets,
                SetRepRangeLowerBound = model.SetRepRangeLowerBound,
                SetRepRangeUpperBound = model.SetRepRangeUpperBound,
                RestTimeSeconds = model.RestTimeSeconds
            };
        }

        public static List<MovementConfigurationDto> ToDtos(this List<MovementConfiguration> model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            if (model.Count == 0)
            {
                return [];
            }

            return model.Select(x => x.ToDto()).ToList();
        }

        public static MovementConfiguration ToEntity(this MovementConfigurationDto model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new MovementConfiguration
            {
                Id = model.Id,
                TotalSets = model.TotalSets,
                SetRepRangeLowerBound = model.SetRepRangeLowerBound,
                SetRepRangeUpperBound = model.SetRepRangeUpperBound,
                RestTimeSeconds = model.RestTimeSeconds
            };
        }

        public static List<MovementConfiguration> ToEntities(this List<MovementConfigurationDto> models)
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
