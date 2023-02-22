using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RUAP_projekt.Migrations
{
    /// <inheritdoc />
    public partial class newentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Area",
                table: "Flags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Flags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Flags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Religion",
                table: "Flags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Zone",
                table: "Flags",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Flags");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Flags");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Flags");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Flags");

            migrationBuilder.DropColumn(
                name: "Zone",
                table: "Flags");
        }
    }
}
