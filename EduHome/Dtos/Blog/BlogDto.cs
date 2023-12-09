namespace EduHome.Dtos.Blog
{
	public class BlogDto
	{
		public Guid Id { get; set; }
		public string SmallImagePath { get; set; }
		public string Creator { get; set; }
		public string Name { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
