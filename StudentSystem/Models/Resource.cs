namespace P01_StudentSystem.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }

    }

}




