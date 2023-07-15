using ImplementingRepository.Models;
using ImplementingRepository.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ImplementingRepository.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeRepository _empRep;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _empRep = new EmployeeRepository();
        }

        public List<Employee> getAllEmployees()
        {
            return _empRep.GetAllEmployees();
        }

        public Employee getEmpById(int id)
        {
            return _empRep.GetEmployeeById(id);
        }

        public IActionResult Index()
        {
            return View();
        }

        

        

    }
}