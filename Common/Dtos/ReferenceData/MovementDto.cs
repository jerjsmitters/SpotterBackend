using System;
using System.Collections.Generic;

namespace Common.Dtos.ReferenceData
{
    public record MovementDto
    {
        public int? Id { get; init; }
        public required string Name { get; init; }
        public required List<MovementConfigurationDto> MovementConfigurations { get; init; }
    }
}
