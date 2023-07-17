using Microsoft.AspNetCore.Mvc;
using ModelDataWithViewDataBagTemp.Models;
using System.Diagnostics;

namespace ModelDataWithViewDataBagTemp.Controllers
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

            //Implementation with Single Obj
            /*MyEmployee employee = new MyEmployee()
            {
               EmpId = 1,
               EmpName = "Test",
               Designation="Dev",
               Salary=123456
            };*/

            var employee = new List<MyEmployee>
            {
               new MyEmployee { EmpId = 1,EmpName="Asif",Designation="Dev",Salary=123456 },
               new MyEmployee { EmpId = 2,EmpName="Asif",Designation="Dev",Salary=123456 },
               new MyEmployee { EmpId = 3,EmpName="Asif",Designation="Dev",Salary=123456 },
               new MyEmployee { EmpId = 4,EmpName="Asif",Designation="Dev",Salary=123456 },
               new MyEmployee { EmpId = 5,EmpName="Asif",Designation="Dev",Salary=123456 },
            };








           /* ViewData["emp"]= employee;*/
            /* ViewBag.emp = employee;*/
            ViewData["emp"] = employee;
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