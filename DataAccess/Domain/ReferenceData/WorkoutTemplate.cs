using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Domain.ReferenceData
{
    public class WorkoutTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ConfiguredMovement> ConfiguredMovements {  get; set; }
    }
}
