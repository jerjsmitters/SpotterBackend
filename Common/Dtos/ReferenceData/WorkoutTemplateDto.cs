using System;
using System.Collections.Generic;

namespace Common.Dtos.ReferenceData
{
    public record WorkoutTemplateDto
    {
        public int? Id { get; init; }
        public required string Name { get; init; }
        public required List<ConfiguredMovementDto> ConfiguredMovements { get; init; }
    }
}
