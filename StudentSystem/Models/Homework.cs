namespace P01_StudentSystem.Models
{
    public class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }

        public string ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }


    }

}




