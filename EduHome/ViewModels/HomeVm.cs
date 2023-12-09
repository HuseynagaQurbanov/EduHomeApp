using EduHome.Dtos.Blog;
using EduHome.Dtos.Course;
using EduHome.Dtos.Event;
using EduHome.Models;

namespace EduHome.ViewModels
{
    public class HomeVm
    {
        public List<Slider>? Sliders { get; set; }
        public List<CourseDto>? Courses { get; set; }
		public List<BlogDto>? Blogs { get; set; }
		public List<EventDto>? Events { get; set; }
	}
}
