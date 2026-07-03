using DTOs.Base;
using DTOs.ReferenceData;
using System;
using System.Collections.Generic;

namespace DTOs.Instance
{
    public record WorkoutInstanceDto : TimedInstanceDto
    {
        public int? Id { get; set; }
        public WorkoutTemplateDto WorkoutTemplate { get; set; }
        public List<WorkoutInstanceMovementDto> WorkoutInstanceMovements { get; set; }
    }
}
