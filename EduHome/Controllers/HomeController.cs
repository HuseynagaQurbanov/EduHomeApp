using EduHome.Data;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Controllers
{
	public class HomeController : Controller
	{
		private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{
            HomeVm vm = new HomeVm();
            vm.Sliders = _context.Sliders.ToList();

			return View(vm);
        }

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}
	}
}
