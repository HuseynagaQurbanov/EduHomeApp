namespace EduHome.Models
{
	public class Faculty : BaseEntity
	{
		public Faculty()
		{
			Teachers = new HashSet<Teacher>();
		}

		public string FacultyName { get; set; }

		public ICollection<Teacher> Teachers { get; set; }
	}
}
