using Microsoft.AspNetCore.Mvc;
using Task_2.Models;
using Task_2.Services;

namespace Task_2.Controllers
{
    public class DayMonthController : Controller
    {
        public DayMonthController(MonthInfo monthInfo, DayInfo dayInfo)
        {
            MonthInfo = monthInfo;
            DayInfo = dayInfo;
        }

        public MonthInfo MonthInfo { get; }
        public DayInfo DayInfo { get; }


        public IActionResult Day()
        {
            return View(DayInfo);
        }

        public IActionResult Month()
        {
            return View(MonthInfo);
        }
    }
}
