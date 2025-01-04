using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class up2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Course_CourseIdentity",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Gymnast_GymnastId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Lesson_CourseIdentity1",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_CourseIdentity1",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_GymnastId",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "CourseIdentity1",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "GymnastId",
                table: "Lesson");

            migrationBuilder.AlterColumn<int>(
                name: "CourseIdentity",
                table: "Lesson",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "GymnastLesson",
                columns: table => new
                {
                    GymnastsId = table.Column<int>(type: "int", nullable: false),
                    lessonsIdentity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymnastLesson", x => new { x.GymnastsId, x.lessonsIdentity });
                    table.ForeignKey(
                        name: "FK_GymnastLesson_Gymnast_GymnastsId",
                        column: x => x.GymnastsId,
                        principalTable: "Gymnast",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymnastLesson_Lesson_lessonsIdentity",
                        column: x => x.lessonsIdentity,
                        principalTable: "Lesson",
                        principalColumn: "Identity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymnastLesson_lessonsIdentity",
                table: "GymnastLesson",
                column: "lessonsIdentity");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Course_CourseIdentity",
                table: "Lesson",
                column: "CourseIdentity",
                principalTable: "Course",
                principalColumn: "Identity",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Course_CourseIdentity",
                table: "Lesson");

            migrationBuilder.DropTable(
                name: "GymnastLesson");

            migrationBuilder.AlterColumn<int>(
                name: "CourseIdentity",
                table: "Lesson",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseIdentity1",
                table: "Lesson",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GymnastId",
                table: "Lesson",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_CourseIdentity1",
                table: "Lesson",
                column: "CourseIdentity1");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_GymnastId",
                table: "Lesson",
                column: "GymnastId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Course_CourseIdentity",
                table: "Lesson",
                column: "CourseIdentity",
                principalTable: "Course",
                principalColumn: "Identity");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Gymnast_GymnastId",
                table: "Lesson",
                column: "GymnastId",
                principalTable: "Gymnast",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Lesson_CourseIdentity1",
                table: "Lesson",
                column: "CourseIdentity1",
                principalTable: "Lesson",
                principalColumn: "Identity",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
