using System;

namespace Common.Dtos.ReferenceData
{
    public record ConfiguredMovementDto
    {
        public int Id { get; set; }
        public MovementDto Movement { get; set; }
        public MovementConfigurationDto MovementConfiguration { get; set; }
        public int Sequence { get; set; }
    }
}
