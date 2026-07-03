using System;

namespace DTOs.Base
{
    public abstract record TimedInstanceDto
    {
        public DateTime StartedDateTime { get; set; }
        public DateTime? CompletedDateTime { get; set; }
    }
}
