using Microsoft.AspNetCore.Mvc;
using ModelAspCore.Models;
using System.Diagnostics;

namespace ModelAspCore.Controllers
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
            var students = new List<StudentDetails>
            {
                new StudentDetails { Id = 1,Name="Asif",Gender="Male",Std="Master"},
                new StudentDetails { Id = 2,Name="Asifa",Gender="Female",Std="Bachelor"},
                new StudentDetails { Id = 3,Name="Areeb",Gender="Male",Std="PGDAC"}
            };
            ViewData["StudentList"]=students;
            return View();
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