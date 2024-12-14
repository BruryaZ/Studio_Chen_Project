using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class createdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LstCourses",
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
                    table.PrimaryKey("PK_LstCourses", x => x.Identity);
                });

            migrationBuilder.CreateTable(
                name: "LstGymnast",
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
                    table.PrimaryKey("PK_LstGymnast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LstTeacher",
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
                    table.PrimaryKey("PK_LstTeacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LstLesson",
                columns: table => new
                {
                    Identity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseIdentity = table.Column<int>(type: "int", nullable: false),
                    MeetNumber = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LstLesson", x => x.Identity);
                    table.ForeignKey(
                        name: "FK_LstLesson_LstCourses_CourseIdentity",
                        column: x => x.CourseIdentity,
                        principalTable: "LstCourses",
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
                        name: "FK_GymnastLesson_LstGymnast_GymnastsId",
                        column: x => x.GymnastsId,
                        principalTable: "LstGymnast",
                        principalColumn: "Id",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymnastLesson");

            migrationBuilder.DropTable(
                name: "LstGymnast");

            migrationBuilder.DropTable(
                name: "LstLesson");

            migrationBuilder.DropTable(
                name: "LstCourses");

            migrationBuilder.DropTable(
                name: "LstTeacher");
        }
    }
}
