using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VarsityManagement.Models;
using VarsityManagement.ViewModels;

namespace VarsityManagement.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext DbContext { get; }

        public HomeController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }





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
