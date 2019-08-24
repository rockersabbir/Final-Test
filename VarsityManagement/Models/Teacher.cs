using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityManagement.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public ICollection<TeacherCourse> TeacherCourses { get; set; } = new List<TeacherCourse>();


        //public int CourseId { get; set; }
        //public Course Course { get; set; }
    }
}
