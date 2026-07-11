using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Domain.Base;
using DataAccess.Domain.ReferenceData;

namespace DataAccess.Domain.Instance
{
    public class WorkoutInstanceMovement : TimedInstance
    {
        public int Id { get; set;  }
        public ConfiguredMovement ConfiguredMovement { get; set; }
        public List<WorkoutInstanceMovementSet> Sets { get; set; }
    }
}
