using Microsoft.AspNetCore.Mvc;

namespace ScratchProject.Controllers
{
	//=>If we use like this way then no need to add Route-Home at other place but method should be mentioned at Method
	[Route("Home")]
	[Route("[controller]")] //1 . token-based
	[Route("[controller]/[action]")] // 2. Token Based
	public class HomeController : Controller
	{
		[Route("")]
		[Route("Home")]
		[Route("Home/Index")]
		[Route("~/")] // => For class level route It should mention mention for root method
					  // => Irrespect for Name of Controller & Method:
					  //Route with Method is sufficient to call a controller-method
		[Route("[action]")] // 1. token
		// Remove Above token					// 2. Token Based
		public IActionResult Index()
		{
			//return View();
			// => If we want to return any specific View named diffirent than controller-method name(Index to SomeOther)
			return View("~/Views/Home/Index.cshtml");
		}

		[Route("Home/About")]
		[Route("[action]")] //1. token
		//remove above token // 2. Token Based
		public IActionResult About()
		{
			return View();
		}

		/*[Route("Home/Details/{id?}")]
		public int Details(int id)
		{
			return id;
		}*/

		[Route("Home/Details/{id?}")]
		[Route("[action]/{id?}")] // 1. token
		[Route("{id?}")]						  // 2. Token Based
		public int Details(int? id)
		{
			return id ?? 6;
		}


	}
}
