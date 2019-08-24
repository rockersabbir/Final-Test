using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VarsityManagement.Models;
using VarsityManagement.ViewModels;

namespace VarsityManagement.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ApplicationDbContext DbContext { get; }

        public HomeController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
       //teacherCourse//////////////////////////////////////////////////////

        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult TeacherIndex()
        {

            List<TeacherInfoViewModel> model = new List<TeacherInfoViewModel>();
            foreach (var std in DbContext.Teachers)
            {
                std.TeacherCourses = DbContext.teacherCourses
                                         .Include(sc => sc.Course)
                                         .Where(sc => sc.TeacherId == std.TeacherId)
                                         .ToList();
                model.Add(new TeacherInfoViewModel { Teacher = std });
            }

            return View(model);
        }
     

        [HttpGet]
        public IActionResult TeacherCreateWithCourse()
        {
            TeacherCreateViewModel model = new TeacherCreateViewModel();
            foreach (var course in DbContext.Courses)
            {
                model.courseList.Add(new SelectListItem
                {
                    Text = course.CourseName,
                    Value = course.CourseId.ToString()
                });
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult TeacherCreateWithCourse(TeacherCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Teacher newTeacher = new Teacher()
                {
                    TeacherName = model.TeacherName,
                };

                DbContext.Teachers.Add(newTeacher);
                DbContext.SaveChanges();

                foreach (var selectedCourse in model.SelectedCourse.Where(s => s.isSelect))
                {
                    var teacherCourse = new TeacherCourse()
                    {
                        CourseId = selectedCourse.CourseId,
                        TeacherId = newTeacher.TeacherId
                    };
                    DbContext.teacherCourses.Add(teacherCourse);
                    DbContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }

            return View(model);
        }


        public IActionResult Index()
        {

            List<StudentInfoViewModel> model = new List<StudentInfoViewModel>();
            foreach (var std in DbContext.Students)
            {
                std.StudentCourses = DbContext.studentCourses
                                         .Include(sc => sc.Course)
                                         .Where(sc => sc.StudentId == std.StudentId)
                                         .ToList();
           
                model.Add(new StudentInfoViewModel { student = std });
            }

            return View(model);

         
        }

        //[HttpGet]
        //public IActionResult Edit()
        //{
        //    StudentCreateViewModel model = new StudentCreateViewModel();
        //    foreach (var course in DbContext.Courses)
        //    {
        //        model.courseList.Add(new SelectListItem
        //        {
        //            Text = course.CourseName,
        //            Value = course.CourseId.ToString()
        //        });
        //    }

        //    return View(model);
        //}

        [HttpGet]
        public IActionResult Create()
        {
            StudentCreateViewModel model = new StudentCreateViewModel();
            foreach (var course in DbContext.Courses)
            {
                model.courseList.Add(new SelectListItem
                {
                    Text = course.CourseName,
                    Value = course.CourseId.ToString()
                });
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Student newStudent = new Student
                {
                    StudentName = model.StudentName,
                };

                DbContext.Students.Add(newStudent);
                DbContext.SaveChanges();

                foreach(var selectedCourse in model.SelectedCourse.Where(s=>s.isSelect))
                {
                    var courseStudent = new StudentCourse()
                    {
                        CourseId = selectedCourse.CourseId,
                        StudentId = newStudent.StudentId
                    };
                    DbContext.studentCourses.Add(courseStudent);
                    DbContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }

            return View(model);
        }

        //[HttpGet]
        //public IActionResult AddCourse(int studentId)
        //{
        //    ViewBag.student = DbContext.Students.FirstOrDefault(s => s.StudentId == studentId);

        //    List<StudentCourse> enrolledCourses = DbContext.studentCourses
        //                                    .Include(sc => sc.Course)
        //                                    .Where(sc => sc.StudentId == studentId)
        //                                    .ToList();
        //    List<int> courseIds = enrolledCourses.Select(c => c.CourseId).ToList();

        //    List<AddCourseViewModel> model = new List<AddCourseViewModel>();
        //    foreach (var course in DbContext.Courses)
        //    {
        //        AddCourseViewModel addCourseView = new AddCourseViewModel
        //        {
        //            CID = course.CourseId,
        //            CName = course.CourseName,
        //            IsSelected = courseIds.Contains(course.CourseId)
        //        };
        //        model.Add(addCourseView);
        //    }
        //    return View(model);
        //}

        //[HttpPost]
        //public IActionResult AddCourse(List<AddCourseViewModel> model, int studentId)
        //{
        //    List<StudentCourse> enrolledCourses = DbContext.studentCourses
        //                                    .Include(sc => sc.Course)
        //                                    .Where(sc => sc.StudentId == studentId)
        //                                    .ToList();
        //    List<int> EnrolledCourseIds = enrolledCourses.Select(c => c.CourseId).ToList();

        //    Student student = DbContext.Students.FirstOrDefault(s => s.StudentId == studentId);

        //    foreach (var item in model)
        //    {
        //        Course course = DbContext.Courses.FirstOrDefault(c => c.CourseId == item.CID);
        //        if (item.IsSelected && !EnrolledCourseIds.Contains(item.CID))
        //        {
        //            StudentCourse studentCourse = new StudentCourse
        //            {
        //                Student = student,
        //                StudentId = student.StudentId,
        //                Course = course,
        //                CourseId = course.CourseId
        //            };
        //            DbContext.studentCourses.Add(studentCourse);
        //            DbContext.SaveChanges();
        //        }
        //        else if (!item.IsSelected && EnrolledCourseIds.Contains(item.CID))
        //        {
        //            var sdtCourse = DbContext.studentCourses.FirstOrDefault(sc => sc.StudentId == student.StudentId && sc.CourseId == course.CourseId);
        //            DbContext.studentCourses.Remove(sdtCourse);
        //            DbContext.SaveChanges();
        //        }
        //    }

        //    return RedirectToAction("Index");
        //}


        [HttpGet]
        public IActionResult CourseDetails()
        {
            List<Course> courses = DbContext.Courses.ToList();

            return View(courses);
        }

        [HttpGet]
        public IActionResult CreateCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourse(CreateCourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                Course newCourse = new Course { CourseName = model.CourseName };
                DbContext.Courses.Add(newCourse);
                DbContext.SaveChanges();

                return RedirectToAction("CourseDetails");
            }

            return View(model);
        }



        [HttpGet]
        public IActionResult EditCourse(int id)
        {
            Course course = DbContext.Courses.FirstOrDefault(c => c.CourseId == id);

            EditCourseViewModel model = new EditCourseViewModel { CourseName = course.CourseName, Id = id };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditCourse(EditCourseViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                Course course = DbContext.Courses.FirstOrDefault(c => c.CourseId == id);

                course.CourseName = model.CourseName;
                DbContext.Courses.Update(course);
                DbContext.SaveChanges();

                return RedirectToAction("CourseDetails");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteCourse(int id)
        {
            var course = DbContext.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course != null)
            {
                DbContext.Courses.Remove(course);
                DbContext.SaveChanges();
                return RedirectToAction("CourseDetails");
            }
            else
            {
                ViewBag.ErrorMessage = $"Course with id: {id} not exist";
                return View("NotFound");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
