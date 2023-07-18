using Microsoft.AspNetCore.Mvc;

namespace InstallingBootstrap.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
