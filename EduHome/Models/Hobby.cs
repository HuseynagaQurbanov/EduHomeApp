using System;

namespace EduHome.Models
{
	public class Hobby : BaseEntity
	{
		public Hobby()
		{
			People = new HashSet<Person>();
		}

		public string Name { get; set; }

		public ICollection<Person> People { get; set; }
	}
}
