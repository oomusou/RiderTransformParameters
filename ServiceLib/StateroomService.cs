using System;

namespace ServiceLib
{
    public class StateroomService
    {
        public decimal TotalAmount(DateTime startTime, DateTime endTime)
        {
            var dailyAmount = 10m;
            var days = (endTime - startTime).Days + 1;
            return dailyAmount * days;
        }
    }
}