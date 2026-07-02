using System;
using System.Collections.Generic;

namespace DTOs.ReferenceData
{
    public class WorkoutTemplateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ConfiguredMovementDto> ConfiguredMovements { get; set; }
    }
}
