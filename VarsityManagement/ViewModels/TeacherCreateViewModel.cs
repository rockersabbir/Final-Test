using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityManagement.ViewModels
{
    public class TeacherCreateViewModel
    {
        public TeacherCreateViewModel()
        {
            courseList = new List<SelectListItem>();
        }

        [Required]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        public List<CourseSelectModelForteacher> SelectedCourse { get; set; }

        public List<SelectListItem> courseList { get; set; }
    }
    public class CourseSelectModelForteacher
    {
        public int CourseId { get; set; }
        public bool isSelect { get; set; }
    }
}
