using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studio_Chen.Data.Migrations
{
    /// <inheritdoc />
    public partial class up17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TZ",
                table: "Teacher",
                newName: "Identity");

            migrationBuilder.RenameColumn(
                name: "TZ",
                table: "Gymnast",
                newName: "Identity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Identity",
                table: "Teacher",
                newName: "TZ");

            migrationBuilder.RenameColumn(
                name: "Identity",
                table: "Gymnast",
                newName: "TZ");
        }
    }
}
