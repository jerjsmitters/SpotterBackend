using Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Instance
{
    public class WorkoutInstanceMovementSet : TimedInstance
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set;  }
    }
}
