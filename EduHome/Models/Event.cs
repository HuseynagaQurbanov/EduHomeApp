namespace EduHome.Models
{
	public class Event : BaseEntity
	{
		public string Name { get; set; }
        public string SmallImagePath { get; set; }
        public string ImagePath { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Venue { get; set; }
		public string Desc { get; set; }
		public List<Speaker> Speakers { get; set; }
	}
}
