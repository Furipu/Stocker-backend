using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class updateproductandproductversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityInStock",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "QuantityPurchased",
                table: "ProductVersion",
                newName: "MetricQuantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MetricQuantity",
                table: "ProductVersion",
                newName: "QuantityPurchased");

            migrationBuilder.AddColumn<int>(
                name: "QuantityInStock",
                table: "Product",
                nullable: false,
                defaultValue: 0);
        }
    }
}
