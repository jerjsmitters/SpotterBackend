using System;
using System.Collections.Generic;

namespace Common.Dtos.ReferenceData
{
    public record WorkoutTemplateDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public List<ConfiguredMovementDto> ConfiguredMovements { get; set; }
    }
}
