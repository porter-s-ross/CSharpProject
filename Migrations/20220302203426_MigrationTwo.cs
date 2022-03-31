using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpProject.Migrations
{
    public partial class MigrationTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arist",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Products",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Arist",
                table: "Products",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}
