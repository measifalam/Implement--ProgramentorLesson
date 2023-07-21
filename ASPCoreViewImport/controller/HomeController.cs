using ASPCoreViewImport.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImport.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="Asif",Gender="Male"},
                new Student{Id=1,Name="Alam",Gender="Male"},
                new Student{Id=1,Name="Asifa",Gender="FeMale"},
            };
            return View(students);
        }

        public IActionResult About()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="Asif",Gender="Male"},
                new Student{Id=1,Name="Alam",Gender="Male"},
                new Student{Id=1,Name="Asifa",Gender="FeMale"},
            };
            return View(students);
        }

        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="Asif",Gender="Male"},
                new Student{Id=1,Name="Alam",Gender="Male"},
                new Student{Id=1,Name="Asifa",Gender="FeMale"},
            };
            return View(students);
        }
    }
}
