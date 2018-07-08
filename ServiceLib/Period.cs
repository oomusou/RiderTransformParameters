using System;

namespace ServiceLib
{
    public class Period
    {
        public Period(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public int Days()
        {
            var days = (EndTime - StartTime).Days + 1;
            return days;
        }
    }
}