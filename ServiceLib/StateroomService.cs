using System;

namespace ServiceLib
{
    public class StateroomService
    {
        private const decimal DailyAmount = 10m;

        public decimal TotalAmount(DateTime startTime, DateTime endTime)
        {
            var days = (endTime - startTime).Days + 1;
            return DailyAmount * days;
        }
    }
}