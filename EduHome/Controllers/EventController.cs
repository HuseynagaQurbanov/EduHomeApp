using EduHome.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Controllers
{
	public class EventController : Controller
	{
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var events = _context.Events.ToList();

            return View(events);
        }

        public IActionResult EventDetail(Guid detailUrl)
        {
            var eventItem = _context.Events.Include(s => s.Speakers).FirstOrDefault(e => e.Id == detailUrl);

            return View(eventItem);
        }
    }
}
