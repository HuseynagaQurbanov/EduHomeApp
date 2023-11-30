using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
