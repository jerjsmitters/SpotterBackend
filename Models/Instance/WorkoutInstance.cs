using Models.Base;
using Models.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Instance
{
    public class WorkoutInstance : TimedInstance
    {
        public int Id { get; set; }
        public WorkoutTemplate WorkoutTemplate { get; set;  }
        public List<WorkoutInstanceMovement> WorkoutInstanceMovements { get; set; }
    }
}
