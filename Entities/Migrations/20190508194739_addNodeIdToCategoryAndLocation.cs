using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class addNodeIdToCategoryAndLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NodeId",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NodeId",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NodeId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "NodeId",
                table: "Category");
        }
    }
}
