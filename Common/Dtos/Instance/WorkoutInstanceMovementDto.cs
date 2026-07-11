using System;
using System.Collections.Generic;
using Common.Dtos.Base;
using Common.Dtos.ReferenceData;

namespace Common.Dtos.Instance
{
    public record WorkoutInstanceMovementDto : TimedInstanceDto
    {
        public int? Id { get; init; }
        public required ConfiguredMovementDto ConfiguredMovement { get; init; }
        public required List<WorkoutInstanceMovementSetDto> Sets { get; init; }
    }
}
