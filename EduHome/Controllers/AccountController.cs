using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
