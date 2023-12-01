using EduHome.Data;
using EduHome.Dtos.Course;
using EduHome.Dtos.Teacher;
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

            var CourseList = _context.Courses.Select(t => new CourseDto()
            {
                Id = t.Id,
                SmallImage = t.SmallImagePath,
				Name = t.Name,
				Desc = t.Desc,
				CreatedDate = t.CreatedDate
            }).OrderByDescending(p => p.CreatedDate).Take(3).ToList();

            HomeVm vm = new HomeVm();
            vm.Sliders = _context.Sliders.ToList();
			vm.Courses = CourseList;

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
