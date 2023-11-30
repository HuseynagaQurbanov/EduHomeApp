using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
