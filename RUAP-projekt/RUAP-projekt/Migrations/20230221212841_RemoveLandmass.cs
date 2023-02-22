using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RUAP_projekt.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLandmass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Landmass",
                table: "Flags");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Landmass",
                table: "Flags",
                type: "int",
                nullable: true);
        }
    }
}
