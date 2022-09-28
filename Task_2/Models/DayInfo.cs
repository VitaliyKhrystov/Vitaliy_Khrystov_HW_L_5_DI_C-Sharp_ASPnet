namespace Task_2.Models
{
    public class DayInfo
    {
        public DayInfo(Day day)
        {
            Day = day;
        }

        public Day Day { get; }

        public string[] GetDaysInfo()
        {
            return Day.Days;
        }
    }
}
