using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpProject.Migrations
{
    public partial class MigrationThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admins_AdminId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admins_AdminId",
                table: "Products",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admins_AdminId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admins_AdminId",
                table: "Products",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
