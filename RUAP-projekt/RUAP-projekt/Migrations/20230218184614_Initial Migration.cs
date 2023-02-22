using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RUAP_projekt.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Landmass = table.Column<int>(type: "int", nullable: false),
                    Bars = table.Column<int>(type: "int", nullable: false),
                    Stripes = table.Column<int>(type: "int", nullable: false),
                    Colours = table.Column<int>(type: "int", nullable: false),
                    Red = table.Column<int>(type: "int", nullable: false),
                    Green = table.Column<int>(type: "int", nullable: false),
                    Blue = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    White = table.Column<int>(type: "int", nullable: false),
                    Black = table.Column<int>(type: "int", nullable: false),
                    Orange = table.Column<int>(type: "int", nullable: false),
                    MainHue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Circles = table.Column<int>(type: "int", nullable: false),
                    Crosses = table.Column<int>(type: "int", nullable: false),
                    Saltires = table.Column<int>(type: "int", nullable: false),
                    Quarters = table.Column<int>(type: "int", nullable: false),
                    Sunstars = table.Column<int>(type: "int", nullable: false),
                    Crescent = table.Column<int>(type: "int", nullable: false),
                    Triangle = table.Column<int>(type: "int", nullable: false),
                    Icon = table.Column<int>(type: "int", nullable: false),
                    Animate = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<int>(type: "int", nullable: false),
                    TopLeft = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BotRight = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flags", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flags");
        }
    }
}
