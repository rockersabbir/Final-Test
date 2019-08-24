using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityManagement.ViewModels
{
    public class StudentCreateViewModel
    {
        public StudentCreateViewModel()
        {
            courseList = new List<SelectListItem>();
        }

        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        public List<CourseSelectModel> SelectedCourse { get; set; }
        
        public List<SelectListItem> courseList { get; set; }
    }
    public class CourseSelectModel
    {
        public int CourseId { get; set; }
        public bool isSelect { get; set; }
    }
   
}
