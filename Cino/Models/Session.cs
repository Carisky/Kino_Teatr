using System;

namespace Cino.Models
{
    public class Session
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Session()
        {
            Start = DateTime.Now;
            End = DateTime.Now;
        }

        public Session(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
    }
}
