using Microsoft.AspNetCore.Mvc;

namespace ScratchProject.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
