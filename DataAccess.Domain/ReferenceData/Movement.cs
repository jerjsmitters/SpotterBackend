using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Domain.ReferenceData
{
    public class Movement
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //primary movers

        //secondary movers

        public List<MovementConfiguration> MovementConfigurations { get; set; }
    }
}
