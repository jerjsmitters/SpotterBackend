using Models.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ReferenceData
{
    //dto
    internal class ConfiguredMovement
    {
        public int Id { get; set;  }
        public Movement Movement { get; set; }
        public MovementConfiguration MovementConfiguration { get; set; }
        public int Sequence { get; set; }
    }
}
