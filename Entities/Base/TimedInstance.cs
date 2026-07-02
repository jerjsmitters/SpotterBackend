using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Base
{
    internal abstract class TimedInstance
    {
        public DateTime StartedDateTime { get; set; }
        public DateTime? CompletedDateTime { get; set; }

        //user data
    }
}
