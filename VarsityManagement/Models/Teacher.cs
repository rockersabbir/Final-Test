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

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
