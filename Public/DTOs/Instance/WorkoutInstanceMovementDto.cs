using DTOs.Base;
using DTOs.ReferenceData;
using System;
using System.Collections.Generic;

namespace DTOs.Instance
{
    public record WorkoutInstanceMovementDto : TimedInstanceDto
    {
        public int Id { get; set; }
        public ConfiguredMovementDto ConfiguredMovement { get; set; }
        public List<WorkoutInstanceMovementSetDto> Sets { get; set; }
    }
}
