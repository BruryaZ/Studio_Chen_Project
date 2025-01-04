using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymnastLesson");

            migrationBuilder.DropTable(
                name: "LstLesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LstTeacher",
                table: "LstTeacher");

            migrationBuilder.RenameTable(
                name: "LstTeacher",
                newName: "Teacher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Identity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetsNumber = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Identity);
                });

            migrationBuilder.CreateTable(
                name: "Gymnast",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gymnast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Identity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseIdentity1 = table.Column<int>(type: "int", nullable: false),
                    MeetNumber = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    CourseIdentity = table.Column<int>(type: "int", nullable: true),
                    GymnastId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Identity);
                    table.ForeignKey(
                        name: "FK_Lesson_Course_CourseIdentity",
                        column: x => x.CourseIdentity,
                        principalTable: "Course",
                        principalColumn: "Identity");
                    table.ForeignKey(
                        name: "FK_Lesson_Gymnast_GymnastId",
                        column: x => x.GymnastId,
                        principalTable: "Gymnast",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lesson_Lesson_CourseIdentity1",
                        column: x => x.CourseIdentity1,
                        principalTable: "Lesson",
                        principalColumn: "Identity",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lesson_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_CourseIdentity",
                table: "Lesson",
                column: "CourseIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_CourseIdentity1",
                table: "Lesson",
                column: "CourseIdentity1");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_GymnastId",
                table: "Lesson",
                column: "GymnastId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_TeacherId",
                table: "Lesson",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Gymnast");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "LstTeacher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LstTeacher",
                table: "LstTeacher",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LstLesson",
                columns: table => new
                {
                    Identity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseIdentity = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeetNumber = table.Column<int>(type: "int", nullable: false),
                    MeetsNumber = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LstLesson", x => x.Identity);
                    table.ForeignKey(
                        name: "FK_LstLesson_LstLesson_CourseIdentity",
                        column: x => x.CourseIdentity,
                        principalTable: "LstLesson",
                        principalColumn: "Identity",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LstLesson_LstTeacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "LstTeacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_GymnastLesson_LstLesson_GymnastsId",
                        column: x => x.GymnastsId,
                        principalTable: "LstLesson",
                        principalColumn: "Identity",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymnastLesson_LstLesson_lessonsIdentity",
                        column: x => x.lessonsIdentity,
                        principalTable: "LstLesson",
                        principalColumn: "Identity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymnastLesson_lessonsIdentity",
                table: "GymnastLesson",
                column: "lessonsIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_LstLesson_CourseIdentity",
                table: "LstLesson",
                column: "CourseIdentity");

            migrationBuilder.CreateIndex(
                name: "IX_LstLesson_TeacherId",
                table: "LstLesson",
                column: "TeacherId");
        }
    }
}
