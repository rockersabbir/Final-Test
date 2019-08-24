using Microsoft.EntityFrameworkCore.Migrations;

namespace VarsityManagement.Migrations
{
    public partial class FluientAPIErrorFinding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourse_Courses_CourseId",
                table: "TeacherCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourse_Teachers_TeacherId",
                table: "TeacherCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherCourse",
                table: "TeacherCourse");

            migrationBuilder.RenameTable(
                name: "TeacherCourse",
                newName: "teacherCourses");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourse_CourseId",
                table: "teacherCourses",
                newName: "IX_teacherCourses_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teacherCourses",
                table: "teacherCourses",
                columns: new[] { "TeacherId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_teacherCourses_Courses_CourseId",
                table: "teacherCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teacherCourses_Teachers_TeacherId",
                table: "teacherCourses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_teacherCourses_Courses_CourseId",
                table: "teacherCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_teacherCourses_Teachers_TeacherId",
                table: "teacherCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teacherCourses",
                table: "teacherCourses");

            migrationBuilder.RenameTable(
                name: "teacherCourses",
                newName: "TeacherCourse");

            migrationBuilder.RenameIndex(
                name: "IX_teacherCourses_CourseId",
                table: "TeacherCourse",
                newName: "IX_TeacherCourse_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherCourse",
                table: "TeacherCourse",
                columns: new[] { "TeacherId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourse_Courses_CourseId",
                table: "TeacherCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourse_Teachers_TeacherId",
                table: "TeacherCourse",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
