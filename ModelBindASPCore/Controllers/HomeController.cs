using Microsoft.AspNetCore.Mvc;
using ModelBindASPCore.Models;
using System.Diagnostics;

namespace ModelBindASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Contact(Employee e)
        {
           
            return "Name:" + e.Name + "Gender" + e.Gender + "Age:" + e.Age + "Description:" + e.Description + "Salary:" + e.Salary + "Maaried:" + e.Married;
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