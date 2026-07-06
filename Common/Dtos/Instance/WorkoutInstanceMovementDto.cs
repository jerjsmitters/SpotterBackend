using System;
using System.Collections.Generic;
using Common.Dtos.Base;
using Common.Dtos.ReferenceData;

namespace Common.Dtos.Instance
{
    public record WorkoutInstanceMovementDto : TimedInstanceDto
    {
        public int Id { get; set; }
        public ConfiguredMovementDto ConfiguredMovement { get; set; }
        public List<WorkoutInstanceMovementSetDto> Sets { get; set; }
    }
}
