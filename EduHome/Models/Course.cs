namespace EduHome.Models
{
	public class Course : BaseEntity
	{
		public string ImagePath { get; set; }
		public string Name { get; set; }
		public string Desc { get; set; }
		public string About { get; set; }
		public string HowToApply { get; set; }
		public string Certification { get; set; }
		public DateTime StartDate { get; set; }
		public string Duration { get; set; }
		public string ClassDuration { get; set; }
		public string SkillLevel { get; set; }
		public int StudentsCount { get; set; }
		public string Assesments { get; set; }
		public double Price { get; set; }
	}
}
