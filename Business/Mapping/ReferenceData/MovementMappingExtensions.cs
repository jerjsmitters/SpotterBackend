using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Mapping.ReferenceData
{
    public static class MovementMappingExtensions
    {
        public static MovementDto ToDto(this Movement model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new MovementDto
            {
                Id = model.Id,
                Name = model.Name,
                MovementConfigurations = model.MovementConfigurations?.ToDtos()
            };
        }

        public static List<MovementDto> ToDtos(this List<Movement> model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            if (model.Count == 0)
            {
                return [];
            }

            return model.Select(x => x.ToDto()).ToList();
        }

        public static Movement ToEntity(this MovementDto model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));

            return new Movement
            {
                Id = model.Id ?? 0,
                Name = model.Name,
                MovementConfigurations = model.MovementConfigurations?.ToEntities()
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
