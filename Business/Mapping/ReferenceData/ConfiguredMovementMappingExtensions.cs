using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Mapping.ReferenceData
{
    public static class ConfiguredMovementMappingExtensions
    {
        public static ConfiguredMovementDto ToDto(this ConfiguredMovement model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new ConfiguredMovementDto
            {
                Id = model.Id,
                Movement = model.Movement?.ToDto(),
                MovementConfiguration = model.MovementConfiguration?.ToDto(),
                Sequence = model.Sequence
            };
        }

        public static List<ConfiguredMovementDto> ToDtos(this List<ConfiguredMovement> model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            if (model.Count == 0)
            {
                return [];
            }

            return model.Select(x => x.ToDto()).ToList();
        }

        public static ConfiguredMovement ToEntity(this ConfiguredMovementDto model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new ConfiguredMovement
            {
                Id = model.Id,
                Movement = model.Movement?.ToEntity(),
                MovementConfiguration = model.MovementConfiguration?.ToEntity(),
                Sequence = model.Sequence
            };
        }

        public static List<ConfiguredMovement> ToEntities(this List<ConfiguredMovementDto> models)
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
