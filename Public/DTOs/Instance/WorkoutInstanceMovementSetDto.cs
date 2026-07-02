using DTOs.Base;
using System;

namespace DTOs.Instance
{
    public class WorkoutInstanceMovementSetDto : TimedInstanceDto
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set; }
    }
}
