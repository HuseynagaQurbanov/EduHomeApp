using EduHome.Data;
using EduHome.Dtos.Blog;
using EduHome.Dtos.Course;
using EduHome.Dtos.Event;
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

			var BlogList = _context.Blogs.Select(b => new BlogDto()
			{
				Id = b.Id,
				SmallImagePath = b.SmallImagePath,
				Name = b.Name,
				Creator = b.Creator,
				CreatedDate = b.CreatedDate
			}).OrderByDescending(p => p.CreatedDate).Take(3).ToList();

            var EventList = _context.Events.Select(e => new EventDto()
            {
                Id = e.Id,
                SmallImagePath = e.SmallImagePath,
                Name = e.Name,
                StartTime = e.StartTime,
				EndTime = e.EndTime,
				Venue = e.Venue,
				CreatedDate = e.CreatedDate,
            }).OrderByDescending(p => p.CreatedDate).Take(4).ToList();


            HomeVm vm = new HomeVm();
            vm.Sliders = _context.Sliders.ToList();
			vm.Courses = CourseList;
			vm.Blogs = BlogList;
			vm.Events = EventList;
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
