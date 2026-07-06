using System;
using System.Collections.Generic;

namespace Common.Dtos.ReferenceData
{
    public record MovementDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public List<MovementConfigurationDto> MovementConfigurations { get; set; }
    }
}
