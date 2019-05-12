using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class changeMetricModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeciLiter",
                table: "Metric");

            migrationBuilder.DropColumn(
                name: "HectoLiter",
                table: "Metric");

            migrationBuilder.DropColumn(
                name: "Kilo",
                table: "Metric");

            migrationBuilder.DropColumn(
                name: "Liter",
                table: "Metric");

            migrationBuilder.DropColumn(
                name: "MiliLiter",
                table: "Metric");

            migrationBuilder.DropColumn(
                name: "Piece",
                table: "Metric");

            migrationBuilder.DropColumn(
                name: "gram",
                table: "Metric");

            migrationBuilder.AddColumn<string>(
                name: "MetricName",
                table: "Metric",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetricName",
                table: "Metric");

            migrationBuilder.AddColumn<decimal>(
                name: "DeciLiter",
                table: "Metric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HectoLiter",
                table: "Metric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Kilo",
                table: "Metric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Liter",
                table: "Metric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MiliLiter",
                table: "Metric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Piece",
                table: "Metric",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "gram",
                table: "Metric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
