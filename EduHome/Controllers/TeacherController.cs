using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
	public class TeacherController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
