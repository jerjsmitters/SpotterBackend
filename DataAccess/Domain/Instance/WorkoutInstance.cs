using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Domain.Base;
using DataAccess.Domain.ReferenceData;

namespace DataAccess.Domain.Instance
{
    public class WorkoutInstance : TimedInstance
    {
        public int? Id { get; set; }
        public WorkoutTemplate WorkoutTemplate { get; set;  }
        public List<WorkoutInstanceMovement> WorkoutInstanceMovements { get; set; }
    }
}
