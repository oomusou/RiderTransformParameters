namespace ServiceLib
{
    public class StateroomService
    {
        private const decimal DailyAmount = 10m;

        public decimal TotalAmount(Period period)
        {
            var days = (period.EndTime - period.StartTime).Days + 1;
            return DailyAmount * days;
        }
    }
}