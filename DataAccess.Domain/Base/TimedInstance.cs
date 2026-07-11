using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Domain.Base
{
    public abstract class TimedInstance
    {
        public DateTime StartedDateTime { get; set; }
        public DateTime? CompletedDateTime { get; set; }

        //user data
    }
}
