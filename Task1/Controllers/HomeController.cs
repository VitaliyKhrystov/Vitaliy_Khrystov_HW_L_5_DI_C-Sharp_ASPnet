using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(double id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}