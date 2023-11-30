using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
	public class EventController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
