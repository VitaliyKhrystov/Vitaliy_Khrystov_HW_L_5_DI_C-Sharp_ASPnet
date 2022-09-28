using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    [BindProperties]
    public class CalculatorController : Controller
    {
        private readonly ICalc<double> calc;
        public Value<double> value { get; set; }

        public CalculatorController(ICalc<double> calc, Value<double> value)
        {
            this.calc = calc;
            this.value = value;
        }
        [HttpPost]
        public IActionResult Add()
        {
            double result = calc.Add(value);
            return RedirectToAction("Index", "Home", new { id = result });
        }
        [HttpPost]
        public IActionResult Mul()
        {
            double result = calc.Mul(value);
            return RedirectToAction("Index", "Home", new { id = result });
        }
        [HttpPost]
        public IActionResult Div()
        {
            double result; 
            
            try
            {
                result = calc.Div(value);
            }
            catch (Exception e)
            {

                return View("Error", new ErrorViewModel() { RequestId = e.Message.ToString()});
            }
            return RedirectToAction("Index", "Home", new { id = result });
        }

        [HttpPost]
        public IActionResult Sub()
        {
            double result = calc.Sub(value);      
            return RedirectToAction("Index", "Home", new { id = result });
        }
    }
}
