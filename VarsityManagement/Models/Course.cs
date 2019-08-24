using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityManagement.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

        public ICollection<TeacherCourse> TeacherCourses { get; set; } = new List<TeacherCourse>();

    }
}
