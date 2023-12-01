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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(new List<Teacher>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    AboutMe = "Her kese salam 33 yasim var",
                    FirstName = "Qudret",
                    LastName = "Qudretov",
                    SmallImagePath="teacher1.jpg",
                    ImagePath = "teacher-details.jpg",
                    Degree = "Master",
                    Experience = "4 year experience"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    AboutMe = "Her kese salam 35 yasim var",
                    FirstName = "Esger",
                    SmallImagePath="teacher10.jpg",
                    LastName = "Letifov",
                    ImagePath = "teacher-details.jpg",
                    Degree = "Master",
                    Experience = "4 year experience"
                },
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
