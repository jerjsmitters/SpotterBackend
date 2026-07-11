using System;

namespace Common.Dtos.ReferenceData
{
    public record MovementConfigurationDto
    {
        public int? Id { get; init; }
        public required int TotalSets { get; init; }
        public required int SetRepRangeLowerBound { get; init; }
        public required int SetRepRangeUpperBound { get; init; }
        public required int RestTimeSeconds { get; init; }
    }
}
