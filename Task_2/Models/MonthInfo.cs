namespace Task_2.Models
{
    public class MonthInfo
    {
        public MonthInfo(Month month)
        {
            Month = month;
        }

        public Month Month { get; }

        public string[] GetMonthInfo()
        {
            return Month.Months;
        }
    }
}
