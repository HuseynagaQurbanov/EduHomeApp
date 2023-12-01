using EduHome.Dtos.Course;
using EduHome.Models;

namespace EduHome.ViewModels
{
    public class HomeVm
    {
        public List<Slider>? Sliders { get; set; }
        public List<CourseDto>? Courses { get; set; }
		public List<Blog>? Blogs { get; set; }
		public List<Event>? Events { get; set; }
	}
}
