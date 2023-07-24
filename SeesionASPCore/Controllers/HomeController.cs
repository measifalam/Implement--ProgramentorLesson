using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Extensions;
using SeesionASPCore.Models;
using System.Diagnostics;

namespace SeesionASPCore.Controllers
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
            HttpContext.Session.SetString("MyKey", "measifalam");
            TempData["Seesion_ID"] = HttpContext.Session.Id;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("MyKey").ToString() != null)
                HttpContext.Session.Remove("MyKey");
            return View();
        }

        public IActionResult About()
        {
            //.data = HttpContext.Session.GetString("MyKey").ToString();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}