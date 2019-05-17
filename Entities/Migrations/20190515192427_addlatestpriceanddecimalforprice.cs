using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class addlatestpriceanddecimalforprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "LowestPricePerUnit",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "LowestPrice",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<decimal>(
                name: "LatestPrice",
                table: "Product",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "latestPricePerUnit",
                table: "Product",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LatestPrice",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "latestPricePerUnit",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "LowestPricePerUnit",
                table: "Product",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "LowestPrice",
                table: "Product",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
