using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class addMetricUnits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MetricId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Metric",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Piece = table.Column<int>(nullable: false),
                    Liter = table.Column<decimal>(nullable: false),
                    DeciLiter = table.Column<decimal>(nullable: false),
                    MiliLiter = table.Column<decimal>(nullable: false),
                    HectoLiter = table.Column<decimal>(nullable: false),
                    Kilo = table.Column<decimal>(nullable: false),
                    gram = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metric", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_MetricId",
                table: "Product",
                column: "MetricId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Metric_MetricId",
                table: "Product",
                column: "MetricId",
                principalTable: "Metric",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Metric_MetricId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Metric");

            migrationBuilder.DropIndex(
                name: "IX_Product_MetricId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MetricId",
                table: "Product");
        }
    }
}
