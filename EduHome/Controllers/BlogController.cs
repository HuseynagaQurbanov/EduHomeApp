using EduHome.Data;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
	public class BlogController : Controller
	{
		private AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{
			var blogs = _context.Blogs.ToList();

			return View(blogs);
		}

        public IActionResult BlogDetails(Guid detailId)
        {
            var blog = _context.Blogs.FirstOrDefault(b => b.Id == detailId);

            if (blog == null) return NotFound();

            return View(blog);
        }
    }
}
