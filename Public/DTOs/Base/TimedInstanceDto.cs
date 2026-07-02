using System;

namespace DTOs.Base
{
    public abstract class TimedInstanceDto
    {
        public DateTime StartedDateTime { get; set; }
        public DateTime? CompletedDateTime { get; set; }
    }
}
