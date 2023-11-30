using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
	public class CourseController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
