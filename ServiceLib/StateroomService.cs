namespace ServiceLib
{
    public class StateroomService
    {
        private const decimal DailyAmount = 10m;

        public decimal TotalAmount(Period period)
        {
            return DailyAmount * period.Days;
        }
    }
}