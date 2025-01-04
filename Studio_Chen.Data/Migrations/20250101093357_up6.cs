using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class up6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Course_CourseIdentity",
                table: "Lesson");

            migrationBuilder.RenameColumn(
                name: "CourseIdentity",
                table: "Lesson",
                newName: "CourseId1");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_CourseIdentity",
                table: "Lesson",
                newName: "IX_Lesson_CourseId1");

            migrationBuilder.RenameColumn(
                name: "Identity",
                table: "Course",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Course_CourseId1",
                table: "Lesson",
                column: "CourseId1",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Course_CourseId1",
                table: "Lesson");

            migrationBuilder.RenameColumn(
                name: "CourseId1",
                table: "Lesson",
                newName: "CourseIdentity");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_CourseId1",
                table: "Lesson",
                newName: "IX_Lesson_CourseIdentity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Course",
                newName: "Identity");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Course_CourseIdentity",
                table: "Lesson",
                column: "CourseIdentity",
                principalTable: "Course",
                principalColumn: "Identity",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
