using Microsoft.AspNetCore.Mvc;
using Strongly_Typed_Views.Models;
using System.Diagnostics;

namespace Strongly_Typed_Views.Controllers
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
            /*Employee employee = new Employee()
            {
                EmpId = 1,
                EmpName = "Test",
                Designation = "Builder",
                Salary = 456237

            };*/

            var employee = new List<Employee>
            {
               new Employee { EmpId = 1,EmpName="Asif",Designation="Dev",Salary=123456 },
               new Employee { EmpId = 2,EmpName="Asif",Designation="Dev",Salary=123456 },
               new Employee { EmpId = 3,EmpName="Asif",Designation="Dev",Salary=123456 },
               new Employee { EmpId = 4,EmpName="Asif",Designation="Dev",Salary=123456 },
               new Employee { EmpId = 5,EmpName="Asif",Designation="Dev",Salary=123456 },
            };
            return View(employee);
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