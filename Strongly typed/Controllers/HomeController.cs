using Microsoft.AspNetCore.Mvc;
using Strongly_typed.Models;
using System.Diagnostics;

namespace Strongly_typed.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Employee obj = new Employee()
            {
                empId = 101,
                empName = "waqar",
                designation = "developer",
                salary = 38400
            };
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
