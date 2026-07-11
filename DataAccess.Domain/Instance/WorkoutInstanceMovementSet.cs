using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Domain.Base;

namespace DataAccess.Domain.Instance
{
    public class WorkoutInstanceMovementSet : TimedInstance
    {
        public int Id { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set;  }
    }
}
