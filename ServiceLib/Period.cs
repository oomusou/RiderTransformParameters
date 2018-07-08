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

        private DateTime StartTime { get; }
        private DateTime EndTime { get; }

        public int Days => (EndTime - StartTime).Days + 1;
    }
}