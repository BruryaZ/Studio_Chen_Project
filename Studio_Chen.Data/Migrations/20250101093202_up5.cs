using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class up5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymnastLesson_Lesson_lessonsIdentity",
                table: "GymnastLesson");

            migrationBuilder.RenameColumn(
                name: "Identity",
                table: "Lesson",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "lessonsIdentity",
                table: "GymnastLesson",
                newName: "lessonsId");

            migrationBuilder.RenameIndex(
                name: "IX_GymnastLesson_lessonsIdentity",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymnastLesson_Lesson_lessonsId",
                table: "GymnastLesson");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lesson",
                newName: "Identity");

            migrationBuilder.RenameColumn(
                name: "lessonsId",
                table: "GymnastLesson",
                newName: "lessonsIdentity");

            migrationBuilder.RenameIndex(
                name: "IX_GymnastLesson_lessonsId",
                table: "GymnastLesson",
                newName: "IX_GymnastLesson_lessonsIdentity");

            migrationBuilder.AddForeignKey(
                name: "FK_GymnastLesson_Lesson_lessonsIdentity",
                table: "GymnastLesson",
                column: "lessonsIdentity",
                principalTable: "Lesson",
                principalColumn: "Identity",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
