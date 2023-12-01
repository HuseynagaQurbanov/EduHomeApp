using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Course> list = _context.Courses.ToList();


            return View(list);
        }

        public IActionResult CourseDetail(Guid detailUrl)
        {
            var course = _context.Courses.FirstOrDefault(p => p.Id == detailUrl);

            return View(course);
        }
    }
}
