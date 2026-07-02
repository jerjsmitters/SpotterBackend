using System;
using System.Collections.Generic;

namespace DTOs.ReferenceData
{
    public class MovementDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MovementConfigurationDto> MovementConfigurations { get; set; }
    }
}
