using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class updateProductEntityLastUpdateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultMetricId",
                table: "Product");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "Product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "DefaultMetricId",
                table: "Product",
                nullable: true);
        }
    }
}
