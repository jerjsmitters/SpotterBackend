using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Domain.ReferenceData;

namespace DataAccess.Domain.ReferenceData
{
    public class ConfiguredMovement
    {
        public int Id { get; set;  }
        public Movement Movement { get; set; }
        public MovementConfiguration MovementConfiguration { get; set; }
        public int Sequence { get; set; }
    }
}
