using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class updateProductVersion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Metric_MetricId",
                table: "ProductVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Product_ProductId",
                table: "ProductVersion");

            migrationBuilder.DropColumn(
                name: "LatestPrice",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LatestPricePerUnit",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LowestPrice",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LowestPricePerUnit",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "NumberInStock",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductVersion",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MetricId",
                table: "ProductVersion",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Metric_MetricId",
                table: "ProductVersion",
                column: "MetricId",
                principalTable: "Metric",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Product_ProductId",
                table: "ProductVersion",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Metric_MetricId",
                table: "ProductVersion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVersion_Product_ProductId",
                table: "ProductVersion");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductVersion",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MetricId",
                table: "ProductVersion",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<decimal>(
                name: "LatestPrice",
                table: "Product",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LatestPricePerUnit",
                table: "Product",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LowestPrice",
                table: "Product",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LowestPricePerUnit",
                table: "Product",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "NumberInStock",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Metric_MetricId",
                table: "ProductVersion",
                column: "MetricId",
                principalTable: "Metric",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVersion_Product_ProductId",
                table: "ProductVersion",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
