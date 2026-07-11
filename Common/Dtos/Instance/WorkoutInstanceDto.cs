using System;
using System.Collections.Generic;
using Common.Dtos.Base;
using Common.Dtos.ReferenceData;

namespace Common.Dtos.Instance
{
    public record WorkoutInstanceDto : TimedInstanceDto
    {
        public int? Id { get; init; }
        public required WorkoutTemplateDto WorkoutTemplate { get; init; }
        public required List<WorkoutInstanceMovementDto> WorkoutInstanceMovements { get; init; }
    }
}
