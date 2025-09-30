using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class tablesconnections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_students_StudentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_students_StudentId",
                table: "Homeworks");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Courses",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_StudentId",
                table: "Courses",
                newName: "IX_Courses_StudentID");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Homeworks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Homeworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CourseId",
                table: "Resources",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_CourseId",
                table: "Homeworks",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_students_StudentID",
                table: "Courses",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Courses_CourseId",
                table: "Homeworks",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_students_StudentId",
                table: "Homeworks",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Courses_CourseId",
                table: "Resources",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_students_StudentID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Courses_CourseId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_students_StudentId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Courses_CourseId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_CourseId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Homeworks_CourseId",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Homeworks");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Courses",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_StudentID",
                table: "Courses",
                newName: "IX_Courses_StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Homeworks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_students_StudentId",
                table: "Courses",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_students_StudentId",
                table: "Homeworks",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId");
        }
    }
}
