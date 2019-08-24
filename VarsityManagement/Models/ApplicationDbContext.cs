using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityManagement.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Many to many
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

              // Many to many
            modelBuilder.Entity<TeacherCourse>()
                .HasKey(sc => new { sc.TeacherId, sc.CourseId });

            modelBuilder.Entity<TeacherCourse>()
                .HasOne(sc => sc.Teacher)
                .WithMany(s => s.TeacherCourses)
                .HasForeignKey(sc => sc.TeacherId);

            modelBuilder.Entity<TeacherCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.TeacherCourses)
                .HasForeignKey(sc => sc.CourseId);

            

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
       
        public DbSet<StudentCourse> studentCourses { get; set; }
        public DbSet<TeacherCourse> teacherCourses  { get; set; }
    }
}
