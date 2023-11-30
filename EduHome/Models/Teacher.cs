namespace EduHome.Models
{
	public class Teacher : Person
	{
		public Teacher()
		{
			Hobbies = new HashSet<Hobby>();
			Faculties = new HashSet<Faculty>();
			//Hobbies = new List<Hobby>();
		}

		public string AboutMe { get; set; }
		public string Degree { get; set; }
		public string Experience { get; set; }

		public ICollection<Faculty> Faculties { get; set; }
	}
}
