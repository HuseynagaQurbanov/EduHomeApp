namespace EduHome.Models
{
	public class Blog : BaseEntity
	{
		public string ImagePath { get; set; }
		public string Name { get; set; }
		public string Desc { get; set; }
		public string Creator { get; set; }
	}
}
