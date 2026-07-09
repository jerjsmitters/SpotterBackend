using Common.Dtos.ReferenceData;
using DataAccess.Domain.ReferenceData;
using Riok.Mapperly.Abstractions;
using System.Collections.Generic;

namespace Business.Mapping.ReferenceData
{
    public static class MovementMappingExtensions
    {
        public static MovementDto ToDto(this Movement model)
        {
            return null;
        }

        public static List<MovementDto> ToDtos(this List<Movement> model)
        {
            return null;
        }

        public static Movement ToEntity(this MovementDto model)
        {
            return null;
        }
    }
}
