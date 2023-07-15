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
			ViewBag.Name = "measifalam";
			ViewBag.Address = "Bhagalpur";
			ViewBag.Designation = "Developer";

            string[] arr = { "Patna", "Ara", "Chapra" };
            ViewBag.StrArr = arr;

            ViewBag.StrList = new List<string>() { "Bhopal", "Kolkata", "Dubai" };
            return View();
		}

		public IActionResult Contact()
		{
			ViewBag.Company = "Elite.Inc";
			ViewData["TagName"] = "Tech Solution";
			return View();
		}
	}
}
