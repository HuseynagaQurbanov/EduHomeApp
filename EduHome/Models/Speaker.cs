namespace EduHome.Models
{
	public class Speaker : BaseEntity
	{
		public string ImagePath { get; set; }
		public string Name { get; set; }
		public string Profession { get; set; }
		public List<Event> Events { get; set; }
	}
}
