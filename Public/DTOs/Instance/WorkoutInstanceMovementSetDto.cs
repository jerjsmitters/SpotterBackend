using DTOs.Base;
using System;

namespace DTOs.Instance
{
    public record WorkoutInstanceMovementSetDto : TimedInstanceDto
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set; }
    }
}
