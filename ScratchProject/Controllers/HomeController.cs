using Microsoft.AspNetCore.Mvc;

namespace ScratchProject.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public int Details(int id)
		{
			return id;
		}


	}
}
