using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class updateProductVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LatestPrice",
                table: "ProductVersion");

            migrationBuilder.DropColumn(
                name: "LatestPricePerUnit",
                table: "ProductVersion");

            migrationBuilder.RenameColumn(
                name: "LowestPricePerUnit",
                table: "ProductVersion",
                newName: "PricePerUnit");

            migrationBuilder.RenameColumn(
                name: "LowestPrice",
                table: "ProductVersion",
                newName: "Price");

            migrationBuilder.AddColumn<int>(
                name: "MetricId",
                table: "ProductVersion",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantityInStock",
                table: "ProductVersion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantityPurchased",
                table: "ProductVersion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersion_MetricId",
                table: "ProductVersion",
                column: "MetricId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Metric_MetricId",
                table: "ProductVersion",
                column: "MetricId",
                principalTable: "Metric",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Metric_MetricId",
                table: "ProductVersion");

            migrationBuilder.DropIndex(
                name: "IX_ProductVersion_MetricId",
                table: "ProductVersion");

            migrationBuilder.DropColumn(
                name: "MetricId",
                table: "ProductVersion");

            migrationBuilder.DropColumn(
                name: "QuantityInStock",
                table: "ProductVersion");

            migrationBuilder.DropColumn(
                name: "QuantityPurchased",
                table: "ProductVersion");

            migrationBuilder.RenameColumn(
                name: "PricePerUnit",
                table: "ProductVersion",
                newName: "LowestPricePerUnit");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ProductVersion",
                newName: "LowestPrice");

            migrationBuilder.AddColumn<decimal>(
                name: "LatestPrice",
                table: "ProductVersion",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LatestPricePerUnit",
                table: "ProductVersion",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
