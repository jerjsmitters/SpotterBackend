using System;

namespace Common.Dtos.Base
{
    public abstract record TimedInstanceDto
    {
        public DateTime StartedDateTime { get; set; }
        public DateTime? CompletedDateTime { get; set; }
    }
}
