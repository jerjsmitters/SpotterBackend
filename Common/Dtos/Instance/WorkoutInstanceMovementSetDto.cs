using System;
using Common.Dtos.Base;

namespace Common.Dtos.Instance
{
    public record WorkoutInstanceMovementSetDto : TimedInstanceDto
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set; }
    }
}
