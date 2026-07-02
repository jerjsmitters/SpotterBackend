using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Template
{
    internal class MovementConfiguration
    {
        public int Id { get; set; }
        public int TotalSets { get; set; }
        public int SetRepRangeLowerBound { get; set; }
        public int SetRepRangeUpperBound { get; set; }
        public int RestTimeSeconds { get; set; }
    }
}
