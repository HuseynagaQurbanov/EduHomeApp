using EduHome.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Hobby> Hobbies { get; set; }
		public DbSet<Faculty> Faculties { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Speaker> Speakers { get; set; }
		public DbSet<Blog> Blogs { get; set; }
	}
}
