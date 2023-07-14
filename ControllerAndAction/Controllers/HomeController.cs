using Microsoft.AspNetCore.Mvc;

namespace ControllerAndAction.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public string DisplayStr()
		{
			return "Asif";
		}

		public int DisplayInt(int id)
		{
			return id;
		}

		public ContentResult ContentResult()
		{
			return Content("A last man who know Every Thing");
		}

		public JsonResult JsonResult()
		{
			var Name = "Md Asif Alam";
			return Json(new {data=Name});
		}

		public ViewResult ViewResult()
		{
			return View("DisplayStr");
		}

		public EmptyResult EmptyResult()
		{
			return new EmptyResult();
		}
	}
}
