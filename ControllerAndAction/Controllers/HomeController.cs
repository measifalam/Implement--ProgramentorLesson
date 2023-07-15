using Microsoft.AspNetCore.Mvc;

namespace ControllerAndAction.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			ViewData["name"] = "Md Asif Alam";
            ViewData["address"] = "Bhagalpur";
            ViewData["designation"] = "Developer";

			string[] arr = { "Patna", "Ara", "Chapra" };
			ViewData["StrArr"]=arr;

			ViewData["StrList"] = new List<string>() { "Bhopal","Kolkata","Dubai" };
            return View();
		}
		 
		public IActionResult About()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}
	}
}
