
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Models
{

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisterOn { get; set; }

        public DateTime Birthday { get; set; }

        public List<Course> CourseEnrollments { get; set; }
        public List<Homework> HomeworkSubmissions { get; set; }


    }
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }

        public List<Resource> Resources { get; set; }
        public List<Homework> HomeworkSubmissions { get; set; }

    }
    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }

    }
    public class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }

        public string ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public Student StudentsEnrolled { get; set; }


    }

    public class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public List<Student> Students { get; set; }

        public List<Course> Courses { get; set; }

    }

}




