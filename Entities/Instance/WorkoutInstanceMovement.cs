using Models.Base;
using Models.ReferenceData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Instance
{
    internal class WorkoutInstanceMovement : TimedInstance
    {
        public int Id { get; set;  }
        public ConfiguredMovement ConfiguredMovement { get; set; }
        public List<WorkoutInstanceMovementSet> Sets { get; set; }
    }
}
