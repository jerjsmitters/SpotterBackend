using System;

namespace DTOs.ReferenceData
{
    public record MovementConfigurationDto
    {
        public int Id { get; set; }
        public int TotalSets { get; set; }
        public int SetRepRangeLowerBound { get; set; }
        public int SetRepRangeUpperBound { get; set; }
        public int RestTimeSeconds { get; set; }
    }
}
