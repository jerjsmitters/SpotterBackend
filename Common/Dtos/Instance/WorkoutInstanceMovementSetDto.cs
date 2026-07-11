using System;
using Common.Dtos.Base;

namespace Common.Dtos.Instance
{
    public record WorkoutInstanceMovementSetDto : TimedInstanceDto
    {
        public int? Id { get; init; }
        public required int SetNumber { get; init; }
        public required int Reps { get; init; }
    }
}
