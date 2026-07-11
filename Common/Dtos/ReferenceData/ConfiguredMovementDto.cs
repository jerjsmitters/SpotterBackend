using System;

namespace Common.Dtos.ReferenceData
{
    public record ConfiguredMovementDto
    {
        public int? Id { get; init; }
        public required MovementDto Movement { get; init; }
        public required MovementConfigurationDto MovementConfiguration { get; init; }
        public int Sequence { get; init; }
    }
}
