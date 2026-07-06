using System;
using System.Collections.Generic;
using Common.Dtos.Base;
using Common.Dtos.ReferenceData;

namespace Common.Dtos.Instance
{
    public record WorkoutInstanceDto : TimedInstanceDto
    {
        public int? Id { get; set; }
        public WorkoutTemplateDto WorkoutTemplate { get; set; }
        public List<WorkoutInstanceMovementDto> WorkoutInstanceMovements { get; set; }
    }
}
