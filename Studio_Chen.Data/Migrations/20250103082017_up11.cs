using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class up11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymnastLesson_Lesson_lessonsId",
                table: "GymnastLesson");

            migrationBuilder.RenameColumn(
                name: "lessonsId",
                table: "GymnastLesson",
                newName: "LessonsId");

            migrationBuilder.RenameIndex(
                name: "IX_GymnastLesson_lessonsId",
                table: "GymnastLesson",
                newName: "IX_GymnastLesson_LessonsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymnastLesson_Lesson_LessonsId",
                table: "GymnastLesson",
                column: "LessonsId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymnastLesson_Lesson_LessonsId",
                table: "GymnastLesson");

            migrationBuilder.RenameColumn(
                name: "LessonsId",
                table: "GymnastLesson",
                newName: "lessonsId");

            migrationBuilder.RenameIndex(
                name: "IX_GymnastLesson_LessonsId",
                table: "GymnastLesson",
                newName: "IX_GymnastLesson_lessonsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GymnastLesson_Lesson_lessonsId",
                table: "GymnastLesson",
                column: "lessonsId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
