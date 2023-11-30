namespace EduHome.Models
{
	public abstract class Person : BaseEntity
	{
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string ImagePath { get; set; }

		public ICollection<Hobby> Hobbies { get; set; }
	}
}
