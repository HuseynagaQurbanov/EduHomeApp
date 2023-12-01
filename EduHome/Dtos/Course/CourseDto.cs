namespace EduHome.Dtos.Course
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string SmallImage { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
